using System.Net;
using System.Text;
using System.Text.Json;
using NUnit.Framework;

namespace Koine.IntegrationTests.Tests;

public sealed class ProgressGraphqlTests : IntegrationTestBase
{
    [Test]
    public async Task ProgressQuery_ReturnsUserProgress()
    {
        var query = new
        {
            query = "query { progress { totalExperience completedLessonIds } }",
        };

        var content = new StringContent(JsonSerializer.Serialize(query), Encoding.UTF8, "application/json");
        var response = await Client.PostAsync("/graphql", content);

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var payload = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(payload);

        Assert.That(doc.RootElement.TryGetProperty("data", out var data), Is.True);
        Assert.That(data.TryGetProperty("progress", out var progress), Is.True);
        Assert.That(progress.TryGetProperty("totalExperience", out var totalExperience), Is.True);
        Assert.That(totalExperience.GetInt32(), Is.GreaterThanOrEqualTo(0));
    }
}
