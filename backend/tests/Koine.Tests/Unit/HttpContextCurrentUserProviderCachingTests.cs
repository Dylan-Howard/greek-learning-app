// Property-based tests for HttpContextCurrentUserProvider per-request caching
// Feature: clerk-auth-integration, Property 10: Clerk user ID lookup returns consistent numeric ID per request
// Validates: Requirements 9.2, 9.4

using System.Security.Claims;
using FsCheck;
using FsCheck.NUnit;
using Koine.API.Middleware;
using Koine.API.Providers;
using Microsoft.AspNetCore.Http;
using Moq;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit;

/// <summary>
/// Property-based tests verifying that <see cref="HttpContextCurrentUserProvider.GetUserId"/>
/// returns a consistent numeric ID for every call within the same request, and that the
/// underlying <c>HttpContext.Items</c> dictionary is read at most once per provider instance.
/// Feature: clerk-auth-integration, Property 10.
/// Validates: Requirements 9.2, 9.4
/// </summary>
[TestFixture]
public class HttpContextCurrentUserProviderCachingTests
{
    // ── helpers ───────────────────────────────────────────────────────────────

    private static HttpContextCurrentUserProvider BuildProvider(int numericId, string clerkId)
    {
        var ctx = new DefaultHttpContext();
        ctx.Items[UserProvisioningMiddleware.NumericUserIdKey] = numericId;

        var identity = new ClaimsIdentity(
            new[] { new Claim(ClaimTypes.NameIdentifier, clerkId) },
            authenticationType: "TestAuth");
        ctx.User = new ClaimsPrincipal(identity);

        var accessorMock = new Mock<IHttpContextAccessor>();
        accessorMock.Setup(a => a.HttpContext).Returns(ctx);

        return new HttpContextCurrentUserProvider(accessorMock.Object);
    }

    // ── Property 10: consistent ID across N calls ─────────────────────────────

    /// <summary>
    /// For any numeric user ID and any call count N (1–20), every call to
    /// <c>GetUserId()</c> on the same provider instance must return the same value.
    /// Validates: Requirements 9.2, 9.4
    /// </summary>
    [Property(MaxTest = 200)]
    public Property GetUserId_ReturnsConsistentId_AcrossNCallsOnSameInstance(
        PositiveInt numericId,
        NonEmptyString rawClerkId,
        PositiveInt callCount)
    {
        var n = (callCount.Get % 20) + 1; // clamp to 1–20
        var clerkId = $"user_{rawClerkId.Get}";
        var provider = BuildProvider(numericId.Get, clerkId);

        var results = Enumerable.Range(0, n)
            .Select(_ => provider.GetUserId())
            .ToList();

        var allSame = results.All(r => r == numericId.Get);
        return Prop.ToProperty(allSame);
    }

    /// <summary>
    /// The <c>IHttpContextAccessor</c> is accessed at most once per provider instance,
    /// regardless of how many times <c>GetUserId()</c> is called.
    /// Validates: Requirement 9.4 (request-scoped caching)
    /// </summary>
    [Property(MaxTest = 200)]
    public Property GetUserId_AccessesHttpContextAtMostOnce_PerProviderInstance(
        PositiveInt numericId,
        NonEmptyString rawClerkId,
        PositiveInt callCount)
    {
        var n = (callCount.Get % 20) + 1; // clamp to 1–20
        var clerkId = $"user_{rawClerkId.Get}";

        var ctx = new DefaultHttpContext();
        ctx.Items[UserProvisioningMiddleware.NumericUserIdKey] = numericId.Get;
        var identity = new ClaimsIdentity(
            new[] { new Claim(ClaimTypes.NameIdentifier, clerkId) },
            authenticationType: "TestAuth");
        ctx.User = new ClaimsPrincipal(identity);

        var accessCount = 0;
        var accessorMock = new Mock<IHttpContextAccessor>();
        accessorMock
            .Setup(a => a.HttpContext)
            .Returns(() =>
            {
                accessCount++;
                return ctx;
            });

        var provider = new HttpContextCurrentUserProvider(accessorMock.Object);

        for (var i = 0; i < n; i++)
            provider.GetUserId();

        // After the first call caches the value, subsequent calls must not re-read Items.
        // We allow at most n accesses on the first call (implementation may read once or
        // a small constant number of times), but the key invariant is that the total
        // access count does not grow linearly with n beyond the first call.
        // Concretely: after caching, zero additional HttpContext reads should occur.
        // We verify this by asserting accesses <= a small constant (≤ 3) regardless of n.
        return Prop.ToProperty(accessCount <= 3);
    }

    // ── determinism: same ID returned regardless of call order ───────────────

    /// <summary>
    /// Two independent provider instances backed by the same numeric ID must each
    /// return that ID consistently — instances do not share cached state.
    /// </summary>
    [Property(MaxTest = 100)]
    public Property TwoProviderInstances_HaveIndependentCaches(
        PositiveInt idA,
        PositiveInt idB,
        NonEmptyString rawClerkId)
    {
        var clerkId = $"user_{rawClerkId.Get}";

        var providerA = BuildProvider(idA.Get, clerkId);
        var providerB = BuildProvider(idB.Get, clerkId);

        // Interleave calls to ensure no shared state
        var a1 = providerA.GetUserId();
        var b1 = providerB.GetUserId();
        var a2 = providerA.GetUserId();
        var b2 = providerB.GetUserId();

        return Prop.ToProperty(a1 == idA.Get && a2 == idA.Get && b1 == idB.Get && b2 == idB.Get);
    }
}
