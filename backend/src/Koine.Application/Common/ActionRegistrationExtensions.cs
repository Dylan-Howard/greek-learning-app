using Microsoft.Extensions.DependencyInjection;

namespace Koine.Application.Common;

/// <summary>
/// Extension methods for registering Koine action classes with the DI container.
/// </summary>
public static class ActionRegistrationExtensions
{
    /// <summary>
    /// Scans the <c>Koine.Application</c> assembly for all concrete, non-abstract
    /// <see cref="BaseAction"/> subclasses and registers each as a scoped service.
    /// Call once from <c>Program.cs</c> — new action classes are discovered automatically.
    /// </summary>
    /// <param name="services">The service collection to register actions into.</param>
    /// <returns>The same <paramref name="services"/> instance for chaining.</returns>
    public static IServiceCollection AddKoineActions(this IServiceCollection services)
    {
        var actionTypes = typeof(BaseAction).Assembly
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseAction)));

        foreach (var type in actionTypes)
            services.AddScoped(type);

        return services;
    }
}
