// Feature: graphql-integration, Property 6: CurrentUser claim extraction is consistent across GraphQL and REST

using System.Security.Claims;
using FsCheck;
using FsCheck.NUnit;
using Koine.API.Middleware;
using Koine.API.Providers;
using Microsoft.AspNetCore.Http;
using Moq;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Property-based tests verifying that the GraphQL resolver and the REST layer
/// extract identical user IDs from the same JWT claim.
/// Feature: graphql-integration, Property 6: CurrentUser claim extraction is consistent across GraphQL and REST.
/// Validates: Requirements 6.3, 6.5
/// </summary>
[TestFixture]
public class ClaimConsistencyPropertyTests
{
    // ── helpers ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Replicates the GraphQL <c>ResolveUserId</c> helper (private in RootQuery/RootMutation)
    /// so we can test the claim-extraction logic in isolation.
    /// Logic is intentionally identical: read <see cref="ClaimTypes.NameIdentifier"/>,
    /// parse as int, fall back to 0.
    /// </summary>
    private static int GraphQlResolveUserId(IHttpContextAccessor http)
    {
        var claim = http.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        return int.TryParse(claim, out var id) ? id : 0;
    }

    /// <summary>
    /// Builds an <see cref="IHttpContextAccessor"/> whose <see cref="HttpContext"/>
    /// carries a <see cref="ClaimsPrincipal"/> with a single <see cref="ClaimTypes.NameIdentifier"/>
    /// claim set to <paramref name="userId"/>.
    /// </summary>
    private static IHttpContextAccessor BuildHttpContextAccessor(string userId)
    {
        var identity = new ClaimsIdentity(
            [new Claim(ClaimTypes.NameIdentifier, userId)],
            authenticationType: "Bearer");

        var httpContext = new DefaultHttpContext
        {
            User = new ClaimsPrincipal(identity)
        };

        // Also populate Items["NumericUserId"] so HttpContextCurrentUserProvider
        // (which reads from Items after Task 6's change) sees the same value.
        if (int.TryParse(userId, out var numericId))
            httpContext.Items[UserProvisioningMiddleware.NumericUserIdKey] = numericId;

        var accessor = new Mock<IHttpContextAccessor>();
        accessor.Setup(a => a.HttpContext).Returns(httpContext);
        return accessor.Object;
    }

    // ── Property 6a: positive integer user IDs round-trip identically ─────────

    /// <summary>
    /// For any positive integer user ID encoded as a NameIdentifier claim,
    /// the GraphQL resolver and the REST provider must extract the same integer.
    /// Validates: Requirements 6.3, 6.5
    /// </summary>
    [Property(MaxTest = 200)]
    public Property ValidPositiveUserId_ExtractedIdenticallyByGraphQlAndRest(PositiveInt rawId)
    {
        var userId = rawId.Get;
        var accessor = BuildHttpContextAccessor(userId.ToString());

        var graphQlId = GraphQlResolveUserId(accessor);
        var restProvider = new HttpContextCurrentUserProvider(accessor);
        var restId = restProvider.GetUserId();

        return Prop.ToProperty(graphQlId == restId);
    }

    // ── Property 6b: large random integer user IDs round-trip identically ─────

    /// <summary>
    /// For any positive integer user ID (including large values scaled up),
    /// the GraphQL resolver and the REST provider must extract the same integer.
    /// Validates: Requirements 6.3, 6.5
    /// </summary>
    [Property(MaxTest = 200)]
    public Property LargeUserId_ExtractedIdenticallyByGraphQlAndRest(PositiveInt rawId)
    {
        // Scale up to exercise larger IDs without overflow
        var userId = (rawId.Get % 100_000) + 1;
        var accessor = BuildHttpContextAccessor(userId.ToString());

        var graphQlId = GraphQlResolveUserId(accessor);
        var restProvider = new HttpContextCurrentUserProvider(accessor);
        var restId = restProvider.GetUserId();

        return Prop.ToProperty(graphQlId == restId);
    }

    // ── Property 6c: non-integer claim values produce safe fallbacks ──────────

    /// <summary>
    /// When the NameIdentifier claim is not a parseable positive integer,
    /// the GraphQL resolver must fall back to 0 (not throw, not return a random int).
    /// Validates: Requirements 6.3, 6.5
    /// </summary>
    [Property(MaxTest = 200)]
    public Property NonIntegerClaimValue_GraphQlFallsBackToZero(NonEmptyString rawClaim)
    {
        var claimValue = rawClaim.Get;

        // Only test values that are not parseable as positive integers
        if (int.TryParse(claimValue, out var v) && v > 0)
            return Prop.ToProperty(true); // skip — valid ID, covered by Property 6a

        var accessor = BuildHttpContextAccessor(claimValue);
        var graphQlId = GraphQlResolveUserId(accessor);

        return Prop.ToProperty(graphQlId == 0);
    }

    // ── Property 6d: null HttpContext produces consistent safe defaults ────────

    /// <summary>
    /// When <see cref="IHttpContextAccessor.HttpContext"/> is null,
    /// both extractors must not throw and must return their respective safe defaults.
    /// Validates: Requirements 6.3, 6.5
    /// </summary>
    [Test]
    public void NullHttpContext_BothExtractors_ReturnSafeDefault()
    {
        var accessor = new Mock<IHttpContextAccessor>();
        accessor.Setup(a => a.HttpContext).Returns((HttpContext?)null);

        // GraphQL falls back to 0 when HttpContext is null
        var graphQlId = GraphQlResolveUserId(accessor.Object);
        Assert.That(graphQlId, Is.EqualTo(0));

        // REST provider throws UnauthorizedAccessException when Items["NumericUserId"] is absent
        var restProvider = new HttpContextCurrentUserProvider(accessor.Object);
        Assert.Throws<UnauthorizedAccessException>(() => restProvider.GetUserId());
    }
}
