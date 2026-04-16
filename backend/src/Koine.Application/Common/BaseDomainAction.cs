using Koine.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Koine.Application.Common;

/// <summary>
/// Abstract base for domain actions. Injects shared infrastructure dependencies
/// (<see cref="DbContext"/> and <see cref="ICurrentUserContext"/>) via constructor
/// and exposes them as <c>protected readonly</c> fields.
/// Contains no business logic and defines no <c>Execute</c> signature.
/// </summary>
public abstract class BaseDomainAction : BaseAction
{
    /// <summary>EF Core database context for the current request scope.</summary>
    protected readonly DbContext Db;

    /// <summary>Provides the authenticated user's numeric database ID.</summary>
    protected readonly ICurrentUserContext UserContext;

    /// <summary>
    /// Initialises a new instance of <see cref="BaseDomainAction"/>.
    /// </summary>
    /// <param name="db">The EF Core database context for the current request scope.</param>
    /// <param name="userContext">The current user context for the current request scope.</param>
    protected BaseDomainAction(DbContext db, ICurrentUserContext userContext)
    {
        Db = db;
        UserContext = userContext;
    }

    /// <summary>
    /// Verifies that an authenticated user is present in the current context.
    /// </summary>
    /// <exception cref="UnauthorizedException">
    /// Thrown when <see cref="ICurrentUserContext.GetUserId"/> throws,
    /// indicating no authenticated user is present.
    /// </exception>
    protected void RequireAuthentication()
    {
        try
        {
            UserContext.GetUserId();
        }
        catch
        {
            throw new UnauthorizedException("Authentication required.");
        }
    }
}
