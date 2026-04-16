namespace Koine.Application.Common.Exceptions;

/// <summary>
/// Thrown when a requested resource cannot be found by its identifier.
/// Maps to HTTP 404 and GraphQL error code <c>NOT_FOUND</c>.
/// </summary>
public class NotFoundException : Exception
{
    /// <summary>
    /// Initialises a <see cref="NotFoundException"/> for a specific resource and identifier.
    /// </summary>
    /// <param name="resourceType">The type name of the resource that was not found (e.g. <c>"User"</c>).</param>
    /// <param name="id">The identifier that was looked up.</param>
    public NotFoundException(string resourceType, object id)
        : base($"{resourceType} with id '{id}' was not found.") { }
}
