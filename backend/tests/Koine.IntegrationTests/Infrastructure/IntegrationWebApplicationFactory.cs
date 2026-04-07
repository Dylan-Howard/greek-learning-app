using System.Data.Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Koine.IntegrationTests.Infrastructure;

public sealed class IntegrationWebApplicationFactory : WebApplicationFactory<Program>
{
    private readonly string _connectionString;

    public IntegrationWebApplicationFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Development");

        builder.ConfigureAppConfiguration((_, config) =>
        {
            var overrides = new Dictionary<string, string?>
            {
                ["ConnectionStrings:DefaultConnection"] = _connectionString,
                ["JwtSettings:SecretKey"] = "IntegrationTestSecretKey_AtLeast32Chars",
                ["JwtSettings:Issuer"] = "KoineIntegration",
                ["JwtSettings:Audience"] = "KoineIntegrationClient",
                ["ClerkSettings:JwksUrl"] = "",
                ["ClerkSettings:Issuer"] = "",
                ["ClerkSettings:AuthorizedParties:0"] = "http://localhost:3000",
            };

            config.AddInMemoryCollection(overrides);
        });

        builder.ConfigureServices(services =>
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = TestAuthHandler.SchemeName;
                options.DefaultChallengeScheme = TestAuthHandler.SchemeName;
                options.DefaultScheme = TestAuthHandler.SchemeName;
            }).AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(TestAuthHandler.SchemeName, _ => { });

            services.RemoveAll<DbConnection>();
        });
    }
}
