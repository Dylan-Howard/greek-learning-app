// Feature: clerk-auth-integration, Property 9: Valid Clerk JWT exposes `sub` claim in HttpContext.User
// Validates: Requirement 8.4

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using FsCheck;
using FsCheck.NUnit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit;

/// <summary>
/// Property-based tests verifying that a valid Clerk JWT causes the <c>sub</c> claim
/// to be available as <c>ClaimTypes.NameIdentifier</c> in <c>HttpContext.User</c>.
/// Feature: clerk-auth-integration, Property 9: Valid Clerk JWT exposes <c>sub</c> claim.
/// Validates: Requirement 8.4
/// </summary>
[TestFixture]
public class JwtClaimExtractionPropertyTests
{
    // ── RSA key pair shared across all tests in this fixture ──────────────────
    private static readonly RSA _rsa = RSA.Create(2048);
    private static readonly RsaSecurityKey _signingKey = new(_rsa);

    private const string ValidIssuer = "https://clerk.test.accounts.dev";
    private const string ValidAzp = "http://localhost:3000";

    // ── test host ─────────────────────────────────────────────────────────────

    /// <summary>
    /// Builds a minimal test host that mirrors the ClerkJwt scheme and writes the
    /// resolved <c>ClaimTypes.NameIdentifier</c> value into the response body so
    /// the test can assert on it.
    /// </summary>
    private static TestServer BuildTestServer()
    {
        var host = new HostBuilder()
            .ConfigureWebHost(webBuilder =>
            {
                webBuilder
                    .UseTestServer()
                    .ConfigureServices(services =>
                    {
                        services.AddAuthentication(options =>
                        {
                            options.DefaultAuthenticateScheme = "ClerkJwt";
                            options.DefaultChallengeScheme = "ClerkJwt";
                        })
                        .AddJwtBearer("ClerkJwt", options =>
                        {
                            options.RequireHttpsMetadata = false;
                            options.TokenValidationParameters = new TokenValidationParameters
                            {
                                ValidateIssuer = true,
                                ValidIssuer = ValidIssuer,
                                // Clerk JWTs use `azp` (authorized party) instead of `aud`.
                                // Disable standard audience validation; azp is checked in OnTokenValidated.
                                ValidateAudience = false,
                                ValidateLifetime = true,
                                ValidateIssuerSigningKey = true,
                                IssuerSigningKey = _signingKey,
                                // Map `sub` → ClaimTypes.NameIdentifier so HttpContext.User.FindFirst works.
                                NameClaimType = ClaimTypes.NameIdentifier,
                            };
                            // Validate azp via the principal claims — works with both JwtSecurityToken
                            // and the newer JsonWebToken used in .NET 8+.
                            options.Events = new JwtBearerEvents
                            {
                                OnTokenValidated = ctx =>
                                {
                                    var azp = ctx.Principal?.FindFirst("azp")?.Value;
                                    if (azp != ValidAzp)
                                        ctx.Fail($"Unauthorized azp claim: '{azp}'.");
                                    return Task.CompletedTask;
                                },
                            };
                        });
                    })
                    .Configure(app =>
                    {
                        app.UseAuthentication();
                        app.Run(async ctx =>
                        {
                            if (ctx.User.Identity?.IsAuthenticated != true)
                            {
                                ctx.Response.StatusCode = 401;
                                return;
                            }

                            // Write the resolved NameIdentifier claim value so the test can read it.
                            var nameId = ctx.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
                            ctx.Response.StatusCode = 200;
                            await ctx.Response.WriteAsync(nameId);
                        });
                    });
            })
            .Build();

        host.Start();
        return host.GetTestServer();
    }

    // ── token factory ─────────────────────────────────────────────────────────

    private static string MakeToken(string sub)
    {
        var now = DateTime.UtcNow;
        var handler = new JwtSecurityTokenHandler();
        var descriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(
            [
                new Claim(JwtRegisteredClaimNames.Sub, sub),
                new Claim("azp", ValidAzp),
            ]),
            Issuer = ValidIssuer,
            NotBefore = now.AddSeconds(-5),
            Expires = now.AddHours(1),
            SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.RsaSha256),
        };
        return handler.WriteToken(handler.CreateToken(descriptor));
    }

    // ── helper ────────────────────────────────────────────────────────────────

    private static (int status, string body) SendRequest(TestServer server, string token)
    {
        return Task.Run(async () =>
        {
            var client = server.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync("/");
            var body = await response.Content.ReadAsStringAsync();
            return ((int)response.StatusCode, body);
        }).GetAwaiter().GetResult();
    }

    // ── Property 9 ────────────────────────────────────────────────────────────

    /// <summary>
    /// For any non-empty Clerk-style user ID string, a valid JWT carrying that value
    /// as the <c>sub</c> claim must result in HTTP 200 and
    /// <c>HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value</c> equalling
    /// the original <c>sub</c> value exactly.
    /// Validates: Requirement 8.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ValidJwt_SubClaimExposedAsNameIdentifier(NonEmptyString rawSub)
    {
        // Prefix with "user_" to mimic real Clerk IDs; avoids edge cases with
        // empty or whitespace-only strings from the generator.
        var sub = $"user_{rawSub.Get}";
        var token = MakeToken(sub);

        using var server = BuildTestServer();
        var (status, body) = SendRequest(server, token);

        return Prop.ToProperty(status == 200 && body == sub);
    }

    /// <summary>
    /// Two different <c>sub</c> values must never produce the same resolved claim —
    /// the mapping is injective (no collisions).
    /// Validates: Requirement 8.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property DifferentSubValues_ProduceDifferentNameIdentifiers(
        NonEmptyString rawA,
        NonEmptyString rawB)
    {
        // Only meaningful when the two generated values are distinct.
        if (rawA.Get == rawB.Get) return Prop.ToProperty(true);

        var subA = $"user_{rawA.Get}";
        var subB = $"user_{rawB.Get}";

        using var server = BuildTestServer();
        var (statusA, bodyA) = SendRequest(server, MakeToken(subA));
        var (statusB, bodyB) = SendRequest(server, MakeToken(subB));

        return Prop.ToProperty(
            statusA == 200 && statusB == 200 && bodyA != bodyB);
    }
}
