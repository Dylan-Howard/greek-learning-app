// Unit tests for UserProvisioningMiddleware
// Feature: clerk-auth-integration, Task 5.1
// Requirements: 10.1, 10.3, 10.4

using System.Security.Claims;
using System.Text.Json;
using Koine.API.Middleware;
using Microsoft.Extensions.Logging;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class UserProvisioningMiddlewareTests
{
    // ── helpers ───────────────────────────────────────────────────────────────

    private static DefaultHttpContext BuildAuthenticatedContext(
        string clerkId,
        string? email = null,
        string? givenName = null)
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, clerkId),
        };
        if (email is not null) claims.Add(new Claim(ClaimTypes.Email, email));
        if (givenName is not null) claims.Add(new Claim(ClaimTypes.GivenName, givenName));

        var identity = new ClaimsIdentity(claims, authenticationType: "TestAuth");
        var ctx = new DefaultHttpContext();
        ctx.User = new ClaimsPrincipal(identity);
        ctx.Response.Body = new MemoryStream();
        return ctx;
    }

    private static DefaultHttpContext BuildUnauthenticatedContext()
    {
        var ctx = new DefaultHttpContext();
        ctx.User = new ClaimsPrincipal(new ClaimsIdentity()); // no authentication type → IsAuthenticated = false
        ctx.Response.Body = new MemoryStream();
        return ctx;
    }

    private static UserProvisioningMiddleware BuildMiddleware(
        RequestDelegate? next = null,
        ILogger<UserProvisioningMiddleware>? logger = null)
    {
        next ??= _ => Task.CompletedTask;
        logger ??= NullLogger<UserProvisioningMiddleware>.Instance;
        return new UserProvisioningMiddleware(next, logger);
    }

    // ── new user ──────────────────────────────────────────────────────────────

    [Test]
    public async Task InvokeAsync_NewUser_CallsProvisionAndSetsNumericUserId()
    {
        // Arrange
        const string clerkId = "user_newAbc123";
        var ctx = BuildAuthenticatedContext(clerkId, email: "new@test.com", givenName: "Alice");

        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId)).ReturnsAsync((User?)null);
        repoMock
            .Setup(r => r.ProvisionClerkUserAsync(clerkId, It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(new User { Id = 42, ClerkId = clerkId, Email = "new@test.com", Username = "alice_bc123" });

        var middleware = BuildMiddleware();

        // Act
        await middleware.InvokeAsync(ctx, repoMock.Object);

        // Assert — provisioning was called exactly once
        repoMock.Verify(r => r.ProvisionClerkUserAsync(clerkId, It.IsAny<string>(), It.IsAny<string>()), Times.Once);

        // Assert — numeric ID stored in Items
        Assert.That(ctx.Items[UserProvisioningMiddleware.NumericUserIdKey], Is.EqualTo(42));
    }

    [Test]
    public async Task InvokeAsync_NewUser_PassesEmailClaimToProvisioning()
    {
        const string clerkId = "user_emailTest";
        const string email = "specific@test.com";
        var ctx = BuildAuthenticatedContext(clerkId, email: email);

        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId)).ReturnsAsync((User?)null);
        repoMock
            .Setup(r => r.ProvisionClerkUserAsync(clerkId, email, It.IsAny<string>()))
            .ReturnsAsync(new User { Id = 7, ClerkId = clerkId, Email = email, Username = "user_st" });

        await BuildMiddleware().InvokeAsync(ctx, repoMock.Object);

        repoMock.Verify(r => r.ProvisionClerkUserAsync(clerkId, email, It.IsAny<string>()), Times.Once);
    }

    [Test]
    public async Task InvokeAsync_NewUser_GeneratesUsernameFallback_WhenNoGivenName()
    {
        const string clerkId = "user_ABCDEF";
        var ctx = BuildAuthenticatedContext(clerkId); // no givenName claim

        string? capturedUsername = null;
        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId)).ReturnsAsync((User?)null);
        repoMock
            .Setup(r => r.ProvisionClerkUserAsync(clerkId, It.IsAny<string>(), It.IsAny<string>()))
            .Callback<string, string, string>((_, _, u) => capturedUsername = u)
            .ReturnsAsync(new User { Id = 1, ClerkId = clerkId, Email = "x@x.com", Username = "user_ABCDEF" });

        await BuildMiddleware().InvokeAsync(ctx, repoMock.Object);

        // Username should end with the last 6 chars of the Clerk ID
        Assert.That(capturedUsername, Does.EndWith("ABCDEF"));
    }

    // ── existing user ─────────────────────────────────────────────────────────

    [Test]
    public async Task InvokeAsync_ExistingUser_DoesNotCallProvision()
    {
        const string clerkId = "user_existing";
        var ctx = BuildAuthenticatedContext(clerkId);
        var existingUser = new User { Id = 99, ClerkId = clerkId, Email = "e@test.com", Username = "existing" };

        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId)).ReturnsAsync(existingUser);

        await BuildMiddleware().InvokeAsync(ctx, repoMock.Object);

        repoMock.Verify(r => r.ProvisionClerkUserAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        Assert.That(ctx.Items[UserProvisioningMiddleware.NumericUserIdKey], Is.EqualTo(99));
    }

    [Test]
    public async Task InvokeAsync_ExistingUser_CallsNextDelegate()
    {
        const string clerkId = "user_existing2";
        var ctx = BuildAuthenticatedContext(clerkId);
        var existingUser = new User { Id = 5, ClerkId = clerkId, Email = "e2@test.com", Username = "ex2" };

        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId)).ReturnsAsync(existingUser);

        var nextCalled = false;
        var middleware = BuildMiddleware(next: _ => { nextCalled = true; return Task.CompletedTask; });

        await middleware.InvokeAsync(ctx, repoMock.Object);

        Assert.That(nextCalled, Is.True);
    }

    // ── unauthenticated ───────────────────────────────────────────────────────

    [Test]
    public async Task InvokeAsync_Unauthenticated_SkipsProvisioningAndCallsNext()
    {
        var ctx = BuildUnauthenticatedContext();
        var repoMock = new Mock<IUserRepository>();
        var nextCalled = false;
        var middleware = BuildMiddleware(next: _ => { nextCalled = true; return Task.CompletedTask; });

        await middleware.InvokeAsync(ctx, repoMock.Object);

        repoMock.Verify(r => r.GetByClerkIdAsync(It.IsAny<string>()), Times.Never);
        Assert.That(nextCalled, Is.True);
        Assert.That(ctx.Items.ContainsKey(UserProvisioningMiddleware.NumericUserIdKey), Is.False);
    }

    // ── DB failure ────────────────────────────────────────────────────────────

    [Test]
    public async Task InvokeAsync_DbUpdateException_Returns503AndLogsError()
    {
        const string clerkId = "user_dbfail";
        var ctx = BuildAuthenticatedContext(clerkId);

        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId))
                .ThrowsAsync(new DbUpdateException("Simulated DB failure"));

        var loggerMock = new Mock<ILogger<UserProvisioningMiddleware>>();
        var middleware = BuildMiddleware(logger: loggerMock.Object);

        await middleware.InvokeAsync(ctx, repoMock.Object);

        // HTTP 503
        Assert.That(ctx.Response.StatusCode, Is.EqualTo(503));

        // JSON body contains expected message
        ctx.Response.Body.Seek(0, SeekOrigin.Begin);
        var body = await new StreamReader(ctx.Response.Body).ReadToEndAsync();
        var doc = JsonDocument.Parse(body);
        Assert.That(doc.RootElement.GetProperty("message").GetString(),
            Is.EqualTo("User provisioning failed. Please try again."));

        // Exception was logged at Error level
        loggerMock.Verify(
            l => l.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, _) => v.ToString()!.Contains(clerkId)),
                It.IsAny<DbUpdateException>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
    }

    [Test]
    public async Task InvokeAsync_DbUpdateException_DoesNotCallNext()
    {
        const string clerkId = "user_dbfail2";
        var ctx = BuildAuthenticatedContext(clerkId);

        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId))
                .ThrowsAsync(new DbUpdateException("Simulated DB failure"));

        var nextCalled = false;
        var middleware = BuildMiddleware(next: _ => { nextCalled = true; return Task.CompletedTask; });

        await middleware.InvokeAsync(ctx, repoMock.Object);

        Assert.That(nextCalled, Is.False);
    }

    [Test]
    public async Task InvokeAsync_ProvisionDbUpdateException_Returns503()
    {
        const string clerkId = "user_provfail";
        var ctx = BuildAuthenticatedContext(clerkId);

        var repoMock = new Mock<IUserRepository>();
        repoMock.Setup(r => r.GetByClerkIdAsync(clerkId)).ReturnsAsync((User?)null);
        repoMock
            .Setup(r => r.ProvisionClerkUserAsync(clerkId, It.IsAny<string>(), It.IsAny<string>()))
            .ThrowsAsync(new DbUpdateException("Constraint violation"));

        await BuildMiddleware().InvokeAsync(ctx, repoMock.Object);

        Assert.That(ctx.Response.StatusCode, Is.EqualTo(503));
    }
}
