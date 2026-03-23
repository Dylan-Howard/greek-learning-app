// Unit tests for HttpContextCurrentUserProvider
// Feature: clerk-auth-integration, Task 6.2
// Requirements: 9.1, 9.3, 9.5

using System.Security.Claims;
using Koine.API.Middleware;
using Koine.API.Providers;
using Microsoft.AspNetCore.Http;
using Moq;

namespace Koine.Tests.Unit;

/// <summary>
/// Unit tests for <see cref="HttpContextCurrentUserProvider"/>.
/// Validates: Requirements 9.1, 9.3, 9.5
/// </summary>
[TestFixture]
public class HttpContextCurrentUserProviderTests
{
    // ── helpers ───────────────────────────────────────────────────────────────

    private static HttpContextCurrentUserProvider BuildProvider(HttpContext ctx)
    {
        var accessorMock = new Mock<IHttpContextAccessor>();
        accessorMock.Setup(a => a.HttpContext).Returns(ctx);
        return new HttpContextCurrentUserProvider(accessorMock.Object);
    }

    private static DefaultHttpContext BuildContextWithNumericId(int numericId, string? clerkId = null)
    {
        var ctx = new DefaultHttpContext();
        ctx.Items[UserProvisioningMiddleware.NumericUserIdKey] = numericId;

        if (clerkId is not null)
        {
            var identity = new ClaimsIdentity(
                new[] { new Claim(ClaimTypes.NameIdentifier, clerkId) },
                authenticationType: "TestAuth");
            ctx.User = new ClaimsPrincipal(identity);
        }

        return ctx;
    }

    private static DefaultHttpContext BuildContextWithClerkIdOnly(string clerkId)
    {
        var ctx = new DefaultHttpContext();
        var identity = new ClaimsIdentity(
            new[] { new Claim(ClaimTypes.NameIdentifier, clerkId) },
            authenticationType: "TestAuth");
        ctx.User = new ClaimsPrincipal(identity);
        return ctx;
    }

    // ── happy path ────────────────────────────────────────────────────────────

    /// <summary>
    /// Requirement 9.1: provider reads numeric ID from HttpContext.Items["NumericUserId"].
    /// </summary>
    [Test]
    public void GetUserId_ReturnsNumericIdFromItems()
    {
        var ctx = BuildContextWithNumericId(42, clerkId: "user_abc123");
        var provider = BuildProvider(ctx);

        var result = provider.GetUserId();

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void GetUserId_ReturnsCorrectId_WhenMultipleItemsPresent()
    {
        var ctx = BuildContextWithNumericId(99, clerkId: "user_xyz");
        ctx.Items["SomeOtherKey"] = "irrelevant";
        var provider = BuildProvider(ctx);

        Assert.That(provider.GetUserId(), Is.EqualTo(99));
    }

    // ── missing item → exception ──────────────────────────────────────────────

    /// <summary>
    /// Requirement 9.3: throws UnauthorizedAccessException when NumericUserId is absent.
    /// </summary>
    [Test]
    public void GetUserId_ThrowsUnauthorizedAccessException_WhenItemAbsent()
    {
        var ctx = BuildContextWithClerkIdOnly("user_missing");
        var provider = BuildProvider(ctx);

        var ex = Assert.Throws<UnauthorizedAccessException>(() => provider.GetUserId());
        Assert.That(ex!.Message, Does.Contain("user_missing"));
    }

    [Test]
    public void GetUserId_ThrowsUnauthorizedAccessException_WhenItemsEmpty()
    {
        var ctx = new DefaultHttpContext();
        var provider = BuildProvider(ctx);

        Assert.Throws<UnauthorizedAccessException>(() => provider.GetUserId());
    }

    [Test]
    public void GetUserId_ExceptionMessage_ContainsClerkId_WhenClaimPresent()
    {
        const string clerkId = "user_clerkAbc";
        var ctx = BuildContextWithClerkIdOnly(clerkId);
        var provider = BuildProvider(ctx);

        var ex = Assert.Throws<UnauthorizedAccessException>(() => provider.GetUserId());
        Assert.That(ex!.Message, Does.Contain(clerkId));
    }

    [Test]
    public void GetUserId_ExceptionMessage_ContainsUnknown_WhenNoClaimPresent()
    {
        var ctx = new DefaultHttpContext(); // no claims, no items
        var provider = BuildProvider(ctx);

        var ex = Assert.Throws<UnauthorizedAccessException>(() => provider.GetUserId());
        Assert.That(ex!.Message, Does.Contain("<unknown>"));
    }

    // ── request-scoped caching ────────────────────────────────────────────────

    /// <summary>
    /// Requirement 9.4: the resolved ID is cached per provider instance (per request).
    /// Calling GetUserId() multiple times returns the same value without re-reading Items.
    /// </summary>
    [Test]
    public void GetUserId_ReturnsSameValue_OnMultipleCalls()
    {
        var ctx = BuildContextWithNumericId(77, clerkId: "user_cached");
        var provider = BuildProvider(ctx);

        var first = provider.GetUserId();
        var second = provider.GetUserId();
        var third = provider.GetUserId();

        Assert.That(first, Is.EqualTo(77));
        Assert.That(second, Is.EqualTo(77));
        Assert.That(third, Is.EqualTo(77));
    }

    [Test]
    public void GetUserId_UsesCache_EvenIfItemsChangedAfterFirstCall()
    {
        // Simulate Items being mutated after the first call — cached value should win.
        var ctx = BuildContextWithNumericId(55, clerkId: "user_mutate");
        var provider = BuildProvider(ctx);

        var first = provider.GetUserId();

        // Mutate Items after first call
        ctx.Items[UserProvisioningMiddleware.NumericUserIdKey] = 999;

        var second = provider.GetUserId();

        Assert.That(first, Is.EqualTo(55));
        Assert.That(second, Is.EqualTo(55)); // still cached value, not 999
    }
}
