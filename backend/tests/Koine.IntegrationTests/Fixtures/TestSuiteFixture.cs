using NUnit.Framework;

namespace Koine.IntegrationTests.Fixtures;

[SetUpFixture]
public sealed class TestSuiteFixture
{
    public static IntegrationTestFixture Fixture { get; private set; } = null!;

    [OneTimeSetUp]
    public async Task GlobalSetup()
    {
        Fixture = new IntegrationTestFixture();
        await Fixture.InitializeAsync();
    }

    [OneTimeTearDown]
    public async Task GlobalTeardown()
    {
        if (Fixture is not null)
        {
            await Fixture.DisposeAsync();
        }
    }
}
