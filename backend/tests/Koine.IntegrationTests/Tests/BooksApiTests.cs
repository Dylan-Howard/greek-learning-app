using System.Net;
using System.Text.Json;
using NUnit.Framework;

namespace Koine.IntegrationTests.Tests;

public sealed class BooksApiTests : IntegrationTestBase
{
    [Test]
    public async Task GetBooks_ReturnsSeededBooks()
    {
        var response = await Client.GetAsync("/api/books");

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var payload = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(payload);

        Assert.That(doc.RootElement.ValueKind, Is.EqualTo(JsonValueKind.Array));
        Assert.That(doc.RootElement.GetArrayLength(), Is.GreaterThan(0));
    }

    [Test]
    public async Task GetBook_ReturnsSingleBook()
    {
        var response = await Client.GetAsync("/api/books/1");

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var payload = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(payload);

        Assert.That(doc.RootElement.TryGetProperty("id", out var idProperty), Is.True);
        Assert.That(idProperty.GetInt32(), Is.EqualTo(1));
    }
}
