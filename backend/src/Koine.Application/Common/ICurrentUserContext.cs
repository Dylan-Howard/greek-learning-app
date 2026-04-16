namespace Koine.Application.Common;

/// <summary>
/// Provides the authenticated user's numeric database ID for the current request scope.
/// Implementations are responsible for resolving the identity from the ambient request context.
/// </summary>
public interface ICurrentUserContext
{
    /// <summary>
    /// Returns the numeric database ID of the currently authenticated user.
    /// </summary>
    /// <returns>The numeric database user ID.</returns>
    /// <exception cref="UnauthorizedAccessException">
    /// Thrown when no authenticated user is present in the current context.
    /// </exception>
    int GetUserId();
}
