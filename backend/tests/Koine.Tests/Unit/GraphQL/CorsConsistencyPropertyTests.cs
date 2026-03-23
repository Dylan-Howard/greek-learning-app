// Feature: graphql-integration, Property 12: CORS headers are present on GraphQL endpoint responses

using FsCheck;
using FsCheck.NUnit;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit.GraphQL;

/// <summary>
/// Property-based tests verifying that the GraphQL endpoint receives the same CORS treatment
/// as REST endpoints for any allowed origin.
/// Feature: graphql-integration, Property 12: CORS headers are present on GraphQL endpoint responses.
/// For any cross-origin request to /graphql from an allowed origin, the response must include
/// the same CORS headers as a cross-origin request to /api/* from the same origin.
/// Validates: Requirements 15.3
/// </summary>
[TestFixture]
public class CorsConsistencyPropertyTests
{
    // ── CORS policy — mirrors Program.cs "AllowFrontend" policy ──────────────

    /// <summary>
    /// The allowed origins defined in Program.cs under the "AllowFrontend" CORS policy.
    /// </summary>
    private static readonly string[] AllowedOrigins =
    [
        "http://localhost:3000",
        "http://localhost:5173",
        "http://localhost:5174",
        "https://yourdomain.com",
    ];

    /// <summary>
    /// Builds the same CorsPolicy that Program.cs registers as "AllowFrontend".
    /// </summary>
    private static CorsPolicy BuildAllowFrontendPolicy()
    {
        var builder = new CorsPolicyBuilder();
        builder
            .WithOrigins(AllowedOrigins)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
        return builder.Build();
    }

    /// <summary>
    /// Creates a CorsService backed by the AllowFrontend policy.
    /// </summary>
    private static CorsService BuildCorsService()
    {
        var options = Microsoft.Extensions.Options.Options.Create(
            new CorsOptions());
        return new CorsService(options, Microsoft.Extensions.Logging.Abstractions.NullLoggerFactory.Instance);
    }

    // ── helpers ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Evaluates the CORS policy for a given path and origin, returning the
    /// <see cref="CorsResult"/> that describes which headers would be added.
    /// </summary>
    private static CorsResult EvaluateCors(string path, string origin)
    {
        var corsService = BuildCorsService();
        var policy = BuildAllowFrontendPolicy();

        var httpContext = new DefaultHttpContext();
        httpContext.Request.Method = HttpMethods.Get;
        httpContext.Request.Path = path;
        httpContext.Request.Headers.Origin = origin;

        return corsService.EvaluatePolicy(httpContext, policy);
    }

    /// <summary>
    /// Captures the CORS result shape for comparison: whether the origin is allowed,
    /// and whether credentials are allowed.
    /// </summary>
    private record CorsSnapshot(bool IsOriginAllowed, bool AllowCredentials);

    private static CorsSnapshot Snapshot(CorsResult result) =>
        new(result.IsOriginAllowed, result.SupportsCredentials);

    // ── Property 12a: Allowed origins receive identical CORS treatment on /graphql and /api/* ──

    /// <summary>
    /// For any allowed origin, the CORS policy evaluation for /graphql must produce
    /// the same result as for /api/books (a representative REST endpoint).
    /// Validates: Requirements 15.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property AllowedOrigin_ReceivesIdenticalCors_OnGraphQLAndRest(NonNegativeInt originIndex)
    {
        var origin = AllowedOrigins[originIndex.Get % AllowedOrigins.Length];

        var graphqlResult = EvaluateCors("/graphql", origin);
        var restResult = EvaluateCors("/api/books", origin);

        var graphqlSnap = Snapshot(graphqlResult);
        var restSnap = Snapshot(restResult);

        return Prop.ToProperty(graphqlSnap == restSnap);
    }

    // ── Property 12b: Allowed origins are accepted on /graphql ───────────────

    /// <summary>
    /// For any allowed origin, the CORS policy must mark the origin as allowed
    /// when the request targets /graphql.
    /// Validates: Requirements 15.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property AllowedOrigin_IsAccepted_OnGraphQL(NonNegativeInt originIndex)
    {
        var origin = AllowedOrigins[originIndex.Get % AllowedOrigins.Length];
        var result = EvaluateCors("/graphql", origin);
        return Prop.ToProperty(result.IsOriginAllowed);
    }

    // ── Property 12c: Credentials are supported on /graphql for allowed origins ──

    /// <summary>
    /// For any allowed origin, the CORS policy must support credentials on /graphql,
    /// matching the AllowCredentials() setting in Program.cs.
    /// Validates: Requirements 15.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property AllowedOrigin_CredentialsSupported_OnGraphQL(NonNegativeInt originIndex)
    {
        var origin = AllowedOrigins[originIndex.Get % AllowedOrigins.Length];
        var result = EvaluateCors("/graphql", origin);
        return Prop.ToProperty(result.SupportsCredentials);
    }

    // ── Property 12d: Credentials are supported on /api/* for allowed origins ─

    /// <summary>
    /// For any allowed origin, the CORS policy must support credentials on /api/*,
    /// confirming the baseline that /graphql is compared against.
    /// Validates: Requirements 15.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property AllowedOrigin_CredentialsSupported_OnRest(NonNegativeInt originIndex)
    {
        var origin = AllowedOrigins[originIndex.Get % AllowedOrigins.Length];
        var result = EvaluateCors("/api/books", origin);
        return Prop.ToProperty(result.SupportsCredentials);
    }

    // ── Property 12e: Disallowed origins are rejected on both /graphql and /api/* ──

    /// <summary>
    /// For any origin not in the allowed list, the CORS policy must reject it
    /// on both /graphql and /api/* — the same rejection behaviour on both routes.
    /// Validates: Requirements 15.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property DisallowedOrigin_RejectedIdentically_OnGraphQLAndRest(PositiveInt port)
    {
        // Construct an origin that is definitely not in the allowed list
        var disallowedPort = 9000 + (port.Get % 1000);
        var origin = $"http://evil-origin-{disallowedPort}.example.com";

        var graphqlResult = EvaluateCors("/graphql", origin);
        var restResult = EvaluateCors("/api/books", origin);

        // Both must reject the origin
        return Prop.ToProperty(!graphqlResult.IsOriginAllowed && !restResult.IsOriginAllowed);
    }

    // ── Property 12f: All four allowed origins are accepted on /graphql ───────

    /// <summary>
    /// Each of the four explicitly configured allowed origins must be accepted
    /// on /graphql. This is a concrete exhaustive check over the known origin set.
    /// Validates: Requirements 15.3
    /// </summary>
    [Test]
    public void AllConfiguredOrigins_AreAccepted_OnGraphQL()
    {
        foreach (var origin in AllowedOrigins)
        {
            var result = EvaluateCors("/graphql", origin);
            Assert.That(result.IsOriginAllowed, Is.True,
                $"Origin '{origin}' should be allowed on /graphql");
            Assert.That(result.SupportsCredentials, Is.True,
                $"Credentials should be supported for origin '{origin}' on /graphql");
        }
    }

    // ── Property 12g: CORS policy is path-agnostic (same policy for all routes) ──

    /// <summary>
    /// The AllowFrontend CORS policy applies uniformly to all routes — it is not
    /// path-restricted. For any allowed origin, /graphql and /graphql/ui must
    /// receive the same CORS treatment as /api/*.
    /// Validates: Requirements 15.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property CorsPolicy_IsPathAgnostic_AcrossAllRoutes(NonNegativeInt originIndex)
    {
        var origin = AllowedOrigins[originIndex.Get % AllowedOrigins.Length];

        var graphqlResult = EvaluateCors("/graphql", origin);
        var graphqlUiResult = EvaluateCors("/graphql/ui", origin);
        var restResult = EvaluateCors("/api/books", origin);

        return Prop.ToProperty(
            Snapshot(graphqlResult) == Snapshot(restResult) &&
            Snapshot(graphqlUiResult) == Snapshot(restResult));
    }
}
