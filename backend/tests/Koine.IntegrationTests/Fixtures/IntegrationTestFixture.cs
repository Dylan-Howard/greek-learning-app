using Koine.Infrastructure.Data.Context;
using Koine.Infrastructure.Data.Seed;
using Koine.IntegrationTests.Infrastructure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Respawn;
using Testcontainers.MsSql;

namespace Koine.IntegrationTests.Fixtures;

public sealed class IntegrationTestFixture : IAsyncDisposable
{
    private readonly MsSqlContainer _container;
    private Respawner? _respawner;

    public IntegrationWebApplicationFactory Factory { get; private set; } = null!;

    public IntegrationTestFixture()
    {
        _container = new MsSqlBuilder()
            .WithImage("mcr.microsoft.com/mssql/server:2022-latest")
            .WithPassword("YourStrong@Passw0rd")
            .Build();
    }

    public async Task InitializeAsync()
    {
        await _container.StartAsync();

        Factory = new IntegrationWebApplicationFactory(_container.GetConnectionString());

        using var scope = Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<KoineDbContext>();
        await context.Database.MigrateAsync();
        await DatabaseSeeder.SeedAsync(scope.ServiceProvider);

        await InitializeRespawnerAsync();
    }

    public async Task ResetAsync()
    {
        if (_respawner == null)
        {
            await InitializeRespawnerAsync();
        }

        await using var connection = new SqlConnection(_container.GetConnectionString());
        await connection.OpenAsync();
        await _respawner!.ResetAsync(connection);

        using var scope = Factory.Services.CreateScope();
        await DatabaseSeeder.SeedAsync(scope.ServiceProvider);
    }

    private async Task InitializeRespawnerAsync()
    {
        await using var connection = new SqlConnection(_container.GetConnectionString());
        await connection.OpenAsync();
        _respawner = await Respawner.CreateAsync(connection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.SqlServer,
            SchemasToInclude = ["dbo"],
            TablesToIgnore = ["__EFMigrationsHistory"],
        });
    }

    public async ValueTask DisposeAsync()
    {
        Factory.Dispose();
        await _container.DisposeAsync();
    }
}
