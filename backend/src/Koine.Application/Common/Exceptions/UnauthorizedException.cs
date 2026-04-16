namespace Koine.Application.Common.Exceptions;

/// <summary>
/// Thrown when an action requires an authenticated user but none is present.
/// Maps to HTTP 401 and GraphQL error code <c>UNAUTHENTICATED</c>.
/// </summary>
/// <param name="message">A human-readable description of the authentication failure.</param>
public class UnauthorizedException(string message) : Exception(message);
