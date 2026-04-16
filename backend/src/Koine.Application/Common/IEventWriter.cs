namespace Koine.Application.Common;

/// <summary>
/// Persists or publishes a domain event to an event store or message bus.
/// Implementations live in <c>Koine.Infrastructure</c>.
/// </summary>
public interface IEventWriter
{
    /// <summary>
    /// Writes <paramref name="domainEvent"/> to the event store or message bus.
    /// </summary>
    /// <typeparam name="TEvent">The domain event type.</typeparam>
    /// <param name="domainEvent">The domain event instance to write.</param>
    Task WriteAsync<TEvent>(TEvent domainEvent);
}
