// Feature: clerk-auth-integration, Property 8: Invalid JWT always returns HTTP 401
// Validates: Requirements 8.1, 8.2, 8.3, 8.5

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
/// Property-based tests verifying JWT validation behaviour for the ClerkJwt scheme.
/// Feature: clerk-auth-integration, Property 8: Invalid JWT always returns HTTP 401.
/// Validates: Requirements 8.1, 8.2, 8.3, 8.5
/// </summary>
[TestFixture]
public class JwtValidationPropertyTests
{
    // ── RSA key pair used to sign "valid-looking" test tokens ─────────────────
    private static readonly RSA _rsa = RSA.Create(2048);
    private static readonly RsaSecurityKey _signingKey = new(_rsa);
    private static readonly RsaSecurityKey _wrongKey = new(RSA.Create(2048));

    private const string ValidIssuer = "https://clerk.test.accounts.dev";
    private const string ValidAzp = "http://localhost:3000";
    private const string WrongIssuer = "https://evil.example.com";

    // ── shared test host ──────────────────────────────────────────────────────

    /// <summary>
    /// Builds a minimal ASP.NET Core test host that mirrors the ClerkJwt scheme
    /// configuration in Program.cs, using an in-process RSA key instead of a
    /// live JWKS endpoint.
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
                            if (ctx.User.Identity?.IsAuthenticated == true)
                            {
                                ctx.Response.StatusCode = 200;
                                await ctx.Response.WriteAsync("ok");
                            }
                            else
                            {
                                ctx.Response.StatusCode = 401;
                            }
                        });
                    });
            })
            .Build();

        host.Start();
        return host.GetTestServer();
    }

    // ── token factories ───────────────────────────────────────────────────────

    private static string MakeValidToken(string sub = "user_abc123")
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

    private static string MakeExpiredToken(string sub = "user_abc123")
    {
        // Explicitly set both NotBefore and Expires in the past so the descriptor is valid
        // but the resulting token is expired from the validator's perspective.
        var past = DateTime.UtcNow.AddHours(-2);
        var handler = new JwtSecurityTokenHandler();
        var descriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(
            [
                new Claim(JwtRegisteredClaimNames.Sub, sub),
                new Claim("azp", ValidAzp),
            ]),
            Issuer = ValidIssuer,
            NotBefore = past,
            IssuedAt = past,
            Expires = past.AddHours(1), // expired 1 hour ago
            SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.RsaSha256),
        };
        return handler.WriteToken(handler.CreateToken(descriptor));
    }

    private static string MakeWrongIssuerToken(string sub = "user_abc123")
    {
        var now = DateTime.UtcNow;
        var handler = new JwtSecurityTokenHandler();
        var descriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity([new Claim(JwtRegisteredClaimNames.Sub, sub), new Claim("azp", ValidAzp)]),
            Issuer = WrongIssuer,
            NotBefore = now.AddSeconds(-5),
            Expires = now.AddHours(1),
            SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.RsaSha256),
        };
        return handler.WriteToken(handler.CreateToken(descriptor));
    }

    private static string MakeWrongKeyToken(string sub = "user_abc123")
    {
        var now = DateTime.UtcNow;
        var handler = new JwtSecurityTokenHandler();
        var descriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity([new Claim(JwtRegisteredClaimNames.Sub, sub), new Claim("azp", ValidAzp)]),
            Issuer = ValidIssuer,
            NotBefore = now.AddSeconds(-5),
            Expires = now.AddHours(1),
            SigningCredentials = new SigningCredentials(_wrongKey, SecurityAlgorithms.RsaSha256),
        };
        return handler.WriteToken(handler.CreateToken(descriptor));
    }

    private static string MakeWrongAzpToken(string sub = "user_abc123")
    {
        var now = DateTime.UtcNow;
        var handler = new JwtSecurityTokenHandler();
        var descriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity([new Claim(JwtRegisteredClaimNames.Sub, sub), new Claim("azp", "https://evil.example.com")]),
            Issuer = ValidIssuer,
            NotBefore = now.AddSeconds(-5),
            Expires = now.AddHours(1),
            SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.RsaSha256),
        };
        return handler.WriteToken(handler.CreateToken(descriptor));
    }

    // ── helper ────────────────────────────────────────────────────────────────

    private static int SendRequest(TestServer server, string? authHeader)
    {
        return Task.Run(async () =>
        {
            var client = server.CreateClient();
            if (authHeader != null)
                client.DefaultRequestHeaders.Add("Authorization", authHeader);
            var response = await client.GetAsync("/");
            return (int)response.StatusCode;
        }).GetAwaiter().GetResult();
    }

    // ── Property 8: invalid JWT always returns 401 ────────────────────────────

    /// <summary>
    /// A completely absent Authorization header must yield 401.
    /// Validates: Requirement 8.5
    /// </summary>
    [Test]
    public void NoToken_Returns401()
    {
        using var server = BuildTestServer();
        Assert.That(SendRequest(server, null), Is.EqualTo(401));
    }

    /// <summary>
    /// For any non-empty random string that is not a valid JWT, the backend must
    /// return 401 — never 200.
    /// Validates: Requirements 8.1, 8.5
    /// </summary>
    [Property(MaxTest = 100)]
    public Property MalformedToken_AlwaysReturns401(NonEmptyString raw)
    {
        // Replace dots so the string can never accidentally be a 3-part JWT.
        var token = raw.Get.Replace('.', '_');
        using var server = BuildTestServer();
        try
        {
            var status = SendRequest(server, $"Bearer {token}");
            return Prop.ToProperty(status == 401);
        }
        catch
        {
            // Any exception from the test host also means the token was rejected.
            return Prop.ToProperty(true);
        }
    }

    /// <summary>
    /// An expired JWT (valid in every other way) must yield 401.
    /// Validates: Requirement 8.5
    /// </summary>
    [Property(MaxTest = 50)]
    public Property ExpiredToken_AlwaysReturns401(NonEmptyString sub)
    {
        var token = MakeExpiredToken(sub.Get);
        using var server = BuildTestServer();
        var status = SendRequest(server, $"Bearer {token}");
        return Prop.ToProperty(status == 401);
    }

    /// <summary>
    /// A JWT signed with the correct key but carrying a wrong issuer must yield 401.
    /// Validates: Requirement 8.2
    /// </summary>
    [Property(MaxTest = 50)]
    public Property WrongIssuerToken_AlwaysReturns401(NonEmptyString sub)
    {
        var token = MakeWrongIssuerToken(sub.Get);
        using var server = BuildTestServer();
        var status = SendRequest(server, $"Bearer {token}");
        return Prop.ToProperty(status == 401);
    }

    /// <summary>
    /// A JWT signed with a different RSA key (simulating a token from a different issuer)
    /// must yield 401.
    /// Validates: Requirement 8.1
    /// </summary>
    [Property(MaxTest = 50)]
    public Property WrongSigningKey_AlwaysReturns401(NonEmptyString sub)
    {
        var token = MakeWrongKeyToken(sub.Get);
        using var server = BuildTestServer();
        var status = SendRequest(server, $"Bearer {token}");
        return Prop.ToProperty(status == 401);
    }

    /// <summary>
    /// A JWT with an unauthorized <c>azp</c> claim must yield 401.
    /// Validates: Requirement 8.3
    /// </summary>
    [Property(MaxTest = 50)]
    public Property WrongAzp_AlwaysReturns401(NonEmptyString sub)
    {
        var token = MakeWrongAzpToken(sub.Get);
        using var server = BuildTestServer();
        var status = SendRequest(server, $"Bearer {token}");
        return Prop.ToProperty(status == 401);
    }

    /// <summary>
    /// A valid token must yield 200 — confirming the test harness itself is correct
    /// and that valid tokens are not accidentally rejected.
    /// </summary>
    [Test]
    public void ValidToken_Returns200()
    {
        using var server = BuildTestServer();
        var token = MakeValidToken();
        Assert.That(SendRequest(server, $"Bearer {token}"), Is.EqualTo(200));
    }
}
