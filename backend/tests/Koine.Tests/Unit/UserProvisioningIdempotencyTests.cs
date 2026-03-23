// Feature: clerk-auth-integration, Property 11: User provisioning is idempotent
// Validates: Requirements 10.1, 10.3

using FsCheck;
using FsCheck.NUnit;
using Koine.Infrastructure.Data.Context;
using Koine.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit;

/// <summary>
/// Property-based tests verifying that <c>ProvisionClerkUserAsync</c> is idempotent:
/// calling it twice with the same Clerk ID always results in exactly one <c>Users</c> record.
/// Feature: clerk-auth-integration, Property 11: User provisioning is idempotent.
/// Validates: Requirements 10.1, 10.3
/// </summary>
[TestFixture]
public class UserProvisioningIdempotencyTests
{
    // ── helpers ───────────────────────────────────────────────────────────────

    private static KoineDbContext CreateContext(string dbName)
    {
        var options = new DbContextOptionsBuilder<KoineDbContext>()
            .UseInMemoryDatabase(dbName)
            .Options;
        return new KoineDbContext(options);
    }

    private static UserRepository CreateRepo(KoineDbContext ctx)
        => new(ctx, NullLogger<UserRepository>.Instance);

    // ── Property 11: provisioning is idempotent ───────────────────────────────

    /// <summary>
    /// For any Clerk ID string, calling <c>ProvisionClerkUserAsync</c> twice must result
    /// in exactly one <c>Users</c> record — the second call must find and return the
    /// existing record without inserting a duplicate.
    /// Validates: Requirements 10.1, 10.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ProvisionCalledTwice_ResultsInExactlyOneRecord(NonEmptyString rawId)
    {
        // Use a unique DB name per run to keep tests isolated
        var dbName = $"idempotency_{rawId.Get}_{Guid.NewGuid():N}";
        var clerkId = $"user_{rawId.Get}";
        var email = $"{rawId.Get}@clerk.test";
        var username = rawId.Get.Length > 6
            ? rawId.Get[..Math.Min(rawId.Get.Length, 10)]
            : rawId.Get + "000000";

        // Run async work synchronously inside the FsCheck property
        var count = Task.Run(async () =>
        {
            await using var ctx = CreateContext(dbName);
            var repo = CreateRepo(ctx);

            await repo.ProvisionClerkUserAsync(clerkId, email, username);
            await repo.ProvisionClerkUserAsync(clerkId, email, username);

            return await ctx.Users.CountAsync(u => u.ClerkId == clerkId);
        }).GetAwaiter().GetResult();

        return Prop.ToProperty(count == 1);
    }

    /// <summary>
    /// The second call must return the same user ID as the first call — not a new record.
    /// Validates: Requirements 10.1, 10.3
    /// </summary>
    [Property(MaxTest = 100)]
    public Property ProvisionCalledTwice_ReturnsSameUserId(NonEmptyString rawId)
    {
        var dbName = $"idempotency_id_{rawId.Get}_{Guid.NewGuid():N}";
        var clerkId = $"user_{rawId.Get}";
        var email = $"{rawId.Get}@clerk.test";
        var username = rawId.Get.Length > 6
            ? rawId.Get[..Math.Min(rawId.Get.Length, 10)]
            : rawId.Get + "000000";

        var (firstId, secondId) = Task.Run(async () =>
        {
            await using var ctx = CreateContext(dbName);
            var repo = CreateRepo(ctx);

            var first = await repo.ProvisionClerkUserAsync(clerkId, email, username);
            var second = await repo.ProvisionClerkUserAsync(clerkId, email, username);

            return (first.Id, second.Id);
        }).GetAwaiter().GetResult();

        return Prop.ToProperty(firstId == secondId && firstId > 0);
    }
}
