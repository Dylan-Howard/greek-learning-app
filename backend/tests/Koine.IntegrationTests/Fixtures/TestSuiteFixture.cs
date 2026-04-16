using System.IO;
using Koine.IntegrationTests.Fixtures;
using NUnit.Framework;

namespace Koine.IntegrationTests;

[SetUpFixture]
public sealed class TestSuiteFixture
{
    public static IntegrationTestFixture Fixture { get; private set; } = null!;

    [OneTimeSetUp]
    public async Task GlobalSetup()
    {
        try
        {
            Fixture = new IntegrationTestFixture();
            await Fixture.InitializeAsync();
        }
        catch (Exception ex) when (IsDockerUnavailable(ex))
        {
            Fixture = null!;
            Assert.Ignore($"Integration tests skipped because Docker is unavailable. {ex.Message}");
        }
    }

    [OneTimeTearDown]
    public async Task GlobalTeardown()
    {
        if (Fixture is not null)
        {
            await Fixture.DisposeAsync();
        }
    }

    private static bool IsDockerUnavailable(Exception ex)
    {
        for (var current = ex; current is not null; current = current.InnerException)
        {
            var name = current.GetType().FullName ?? string.Empty;
            if (name.StartsWith("Docker.DotNet.", StringComparison.Ordinal))
            {
                return true;
            }

            if (current is IOException)
            {
                return true;
            }

            if (current.Message.Contains("Docker", StringComparison.OrdinalIgnoreCase) ||
                current.Message.Contains("containerd", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}
