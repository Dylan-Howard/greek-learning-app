namespace Koine.Application.Common.Exceptions;

/// <summary>
/// Thrown when an authenticated user lacks the required permission to perform an action.
/// Maps to HTTP 403 and GraphQL error code <c>FORBIDDEN</c>.
/// </summary>
/// <param name="message">A human-readable description of the permission failure.</param>
public class ForbiddenException(string message) : Exception(message);
