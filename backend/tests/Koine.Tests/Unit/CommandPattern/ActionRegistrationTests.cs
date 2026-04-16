// Feature: command-pattern-architecture, Property 12: DI registration discovers all concrete BaseAction subclasses
// Validates: Requirements 6.1, 6.4

using FsCheck;
using FsCheck.NUnit;
using Koine.Application.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Prop = FsCheck.Fluent.Prop;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Koine.Tests.Unit.CommandPattern;

/// <summary>
/// Property-based tests verifying that <see cref="ActionRegistrationExtensions.AddKoineActions"/>
/// discovers and registers all concrete <see cref="BaseAction"/> subclasses as scoped services.
/// Feature: command-pattern-architecture, Property 12.
/// Validates: Requirements 6.1, 6.4
/// </summary>
[TestFixture]
public class ActionRegistrationTests
{
    /// <summary>
    /// Builds a <see cref="ServiceProvider"/> that includes the minimum dependencies
    /// required to resolve any <see cref="BaseAction"/> subclass registered by
    /// <see cref="ActionRegistrationExtensions.AddKoineActions"/>.
    /// </summary>
    private static ServiceProvider BuildProvider()
    {
        var services = new ServiceCollection();

        // Register AddKoineActions — the method under test
        services.AddKoineActions();

        // Register supporting dependencies that concrete actions depend on
        services.AddDbContext<DbContext, TestDbContext>(o =>
            o.UseInMemoryDatabase("ActionRegistrationTest"));
        services.AddScoped<ICurrentUserContext>(_ => new Mock<ICurrentUserContext>().Object);
        services.AddScoped<IEventWriter>(_ => new Mock<IEventWriter>().Object);

        return services.BuildServiceProvider();
    }

    /// <summary>
    /// Property 12: For every concrete <see cref="BaseAction"/> subclass in the assembly,
    /// <see cref="ActionRegistrationExtensions.AddKoineActions"/> must register it so that
    /// it can be resolved as a scoped service from the DI container.
    /// Validates: Requirements 6.1, 6.4
    /// </summary>
    [Property(MaxTest = 100)]
    public Property AddKoineActions_RegistersAllConcreteBaseActionSubclasses(PositiveInt seed)
    {
        var concreteActionTypes = typeof(BaseAction).Assembly
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseAction)))
            .ToList();

        if (concreteActionTypes.Count == 0)
            return Prop.ToProperty(true); // vacuously true if no actions exist yet

        using var provider = BuildProvider();

        var allResolvable = concreteActionTypes.All(type =>
        {
            try
            {
                using var scope = provider.CreateScope();
                var service = scope.ServiceProvider.GetService(type);
                return service is not null;
            }
            catch
            {
                return false;
            }
        });

        return Prop.ToProperty(allResolvable);
    }

    /// <summary>
    /// Verifies that the total count of registered action types equals the number of
    /// concrete <see cref="BaseAction"/> subclasses discovered by reflection — ensuring
    /// no duplicates and no omissions.
    /// Validates: Requirements 6.1, 6.4
    /// </summary>
    [Test]
    public void AddKoineActions_RegistersExactlyAllConcreteBaseActionSubclasses()
    {
        var concreteActionTypes = typeof(BaseAction).Assembly
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseAction)))
            .ToList();

        var services = new ServiceCollection();
        services.AddKoineActions();

        var registeredActionCount = services
            .Count(sd => concreteActionTypes.Contains(sd.ServiceType));

        Assert.That(registeredActionCount, Is.EqualTo(concreteActionTypes.Count));
    }

    /// <summary>
    /// Verifies that all action types are registered with <see cref="ServiceLifetime.Scoped"/>.
    /// Validates: Requirement 6.1
    /// </summary>
    [Test]
    public void AddKoineActions_RegistersAllActionsAsScoped()
    {
        var concreteActionTypes = typeof(BaseAction).Assembly
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseAction)))
            .ToList();

        var services = new ServiceCollection();
        services.AddKoineActions();

        var nonScopedRegistrations = services
            .Where(sd => concreteActionTypes.Contains(sd.ServiceType)
                         && sd.Lifetime != ServiceLifetime.Scoped)
            .ToList();

        Assert.That(nonScopedRegistrations, Is.Empty,
            "All action types must be registered as Scoped.");
    }

    // ── Helper DbContext ──────────────────────────────────────────────────────

    /// <summary>
    /// Minimal in-memory <see cref="DbContext"/> used to satisfy the
    /// <see cref="DbContext"/> constructor parameter of <see cref="BaseDomainAction"/>
    /// subclasses during DI resolution in tests.
    /// </summary>
    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options);
}
