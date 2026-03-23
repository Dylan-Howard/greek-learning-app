// Unit tests for UserRepository.GetByClerkIdAsync and ProvisionClerkUserAsync
// Feature: clerk-auth-integration, Task 2

using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;
using Koine.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace Koine.Tests.Unit;

[TestFixture]
public class UserRepositoryTests
{
    // ── helpers ───────────────────────────────────────────────────────────────

    /// <summary>
    /// Creates a fresh in-memory <see cref="KoineDbContext"/> with a unique database name
    /// so each test is fully isolated.
    /// </summary>
    private static KoineDbContext CreateContext(string dbName)
    {
        var options = new DbContextOptionsBuilder<KoineDbContext>()
            .UseInMemoryDatabase(dbName)
            .Options;
        return new KoineDbContext(options);
    }

    private static UserRepository CreateRepo(KoineDbContext ctx)
        => new(ctx, NullLogger<UserRepository>.Instance);

    // ── GetByClerkIdAsync ─────────────────────────────────────────────────────

    [Test]
    public async Task GetByClerkIdAsync_ReturnsUser_WhenClerkIdExists()
    {
        await using var ctx = CreateContext(nameof(GetByClerkIdAsync_ReturnsUser_WhenClerkIdExists));
        ctx.Users.Add(new User { ClerkId = "user_abc123", Email = "a@test.com", Username = "alice" });
        await ctx.SaveChangesAsync();

        var repo = CreateRepo(ctx);
        var result = await repo.GetByClerkIdAsync("user_abc123");

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.ClerkId, Is.EqualTo("user_abc123"));
    }

    [Test]
    public async Task GetByClerkIdAsync_ReturnsNull_WhenClerkIdAbsent()
    {
        await using var ctx = CreateContext(nameof(GetByClerkIdAsync_ReturnsNull_WhenClerkIdAbsent));
        var repo = CreateRepo(ctx);

        var result = await repo.GetByClerkIdAsync("user_nonexistent");

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task GetByClerkIdAsync_ReturnsNull_WhenOnlyNullClerkIdExists()
    {
        await using var ctx = CreateContext(nameof(GetByClerkIdAsync_ReturnsNull_WhenOnlyNullClerkIdExists));
        ctx.Users.Add(new User { ClerkId = null, Email = "b@test.com", Username = "bob" });
        await ctx.SaveChangesAsync();

        var repo = CreateRepo(ctx);
        var result = await repo.GetByClerkIdAsync("user_abc123");

        Assert.That(result, Is.Null);
    }

    // ── ProvisionClerkUserAsync ───────────────────────────────────────────────

    [Test]
    public async Task ProvisionClerkUserAsync_CreatesNewUser_WhenClerkIdNotFound()
    {
        await using var ctx = CreateContext(nameof(ProvisionClerkUserAsync_CreatesNewUser_WhenClerkIdNotFound));
        var repo = CreateRepo(ctx);

        var user = await repo.ProvisionClerkUserAsync("user_new1", "new@test.com", "new_user1");

        Assert.That(user, Is.Not.Null);
        Assert.That(user.ClerkId, Is.EqualTo("user_new1"));
        Assert.That(user.Email, Is.EqualTo("new@test.com"));
        Assert.That(user.Username, Is.EqualTo("new_user1"));
        Assert.That(user.Id, Is.GreaterThan(0));
    }

    [Test]
    public async Task ProvisionClerkUserAsync_PersistsExactlyOneRecord_WhenCalledOnce()
    {
        await using var ctx = CreateContext(nameof(ProvisionClerkUserAsync_PersistsExactlyOneRecord_WhenCalledOnce));
        var repo = CreateRepo(ctx);

        await repo.ProvisionClerkUserAsync("user_once", "once@test.com", "once_user");

        var count = await ctx.Users.CountAsync(u => u.ClerkId == "user_once");
        Assert.That(count, Is.EqualTo(1));
    }

    [Test]
    public async Task ProvisionClerkUserAsync_ReturnsExistingUser_WhenClerkIdAlreadyExists()
    {
        await using var ctx = CreateContext(nameof(ProvisionClerkUserAsync_ReturnsExistingUser_WhenClerkIdAlreadyExists));
        ctx.Users.Add(new User { ClerkId = "user_exists", Email = "exists@test.com", Username = "existing" });
        await ctx.SaveChangesAsync();

        var repo = CreateRepo(ctx);
        var result = await repo.ProvisionClerkUserAsync("user_exists", "other@test.com", "other_name");

        // Must return the original record unchanged
        Assert.That(result.Email, Is.EqualTo("exists@test.com"));
        Assert.That(result.Username, Is.EqualTo("existing"));
    }

    [Test]
    public async Task ProvisionClerkUserAsync_DoesNotCreateDuplicate_WhenCalledTwice()
    {
        await using var ctx = CreateContext(nameof(ProvisionClerkUserAsync_DoesNotCreateDuplicate_WhenCalledTwice));
        var repo = CreateRepo(ctx);

        await repo.ProvisionClerkUserAsync("user_dup", "dup@test.com", "dup_user");
        await repo.ProvisionClerkUserAsync("user_dup", "dup@test.com", "dup_user");

        var count = await ctx.Users.CountAsync(u => u.ClerkId == "user_dup");
        Assert.That(count, Is.EqualTo(1));
    }

    [Test]
    public async Task ProvisionClerkUserAsync_SetsCreatedAt_OnNewUser()
    {
        await using var ctx = CreateContext(nameof(ProvisionClerkUserAsync_SetsCreatedAt_OnNewUser));
        var before = DateTime.UtcNow.AddSeconds(-1);
        var repo = CreateRepo(ctx);

        var user = await repo.ProvisionClerkUserAsync("user_ts", "ts@test.com", "ts_user");

        Assert.That(user.CreatedAt, Is.GreaterThan(before));
    }
}
