namespace Koine.Application.Common.Exceptions;

/// <summary>
/// Thrown when an action requires an authenticated user but none is present.
/// Maps to HTTP 401 in controllers and <c>"UNAUTHENTICATED"</c> in GraphQL resolvers.
/// </summary>
public class UnauthorizedException(string message) : Exception(message);
