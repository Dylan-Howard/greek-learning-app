using System.Net;
using System.Text.Json;
using NUnit.Framework;

namespace Koine.IntegrationTests.Tests;

public sealed class ReaderApiTests : IntegrationTestBase
{
    [Test]
    public async Task GetReaderChapter_ReturnsRenderedText()
    {
        var response = await Client.GetAsync("/api/reader?book=1&chapter=1&lang=en");

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var payload = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(payload);

        Assert.That(doc.RootElement.TryGetProperty("title", out var title), Is.True);
        Assert.That(title.GetString(), Is.Not.Empty);
        Assert.That(doc.RootElement.TryGetProperty("units", out var units), Is.True);
        Assert.That(units.ValueKind, Is.EqualTo(JsonValueKind.Array));
        Assert.That(units.GetArrayLength(), Is.GreaterThan(0));
    }
}
