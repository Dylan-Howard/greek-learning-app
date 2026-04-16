using System.Net.Http.Headers;
using Koine.IntegrationTests;
using Koine.IntegrationTests.Fixtures;
using NUnit.Framework;

namespace Koine.IntegrationTests.Tests;

public abstract class IntegrationTestBase
{
    protected HttpClient Client { get; private set; } = null!;

    protected IntegrationTestFixture Fixture => TestSuiteFixture.Fixture;

    [SetUp]
    public async Task SetUpAsync()
    {
        await Fixture.ResetAsync();
        Client = Fixture.Factory.CreateClient();
        Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    [TearDown]
    public void TearDown()
    {
        Client.Dispose();
    }
}
