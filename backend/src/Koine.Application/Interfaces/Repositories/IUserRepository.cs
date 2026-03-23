using Koine.Domain.Entities;

// Koine.Application/Interfaces/Repositories/IUserRepository.cs
namespace Koine.Application.Interfaces.Repositories
{
    /// <summary>
    /// Repository contract for <see cref="User"/> persistence operations.
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Looks up a user by their email address.
        /// </summary>
        /// <param name="email">The email address to search for.</param>
        /// <returns>The matching <see cref="User"/>, or <c>null</c> if not found.</returns>
        Task<User?> GetByEmailAsync(string email);

        /// <summary>
        /// Looks up a user by their username.
        /// </summary>
        /// <param name="username">The username to search for.</param>
        /// <returns>The matching <see cref="User"/>, or <c>null</c> if not found.</returns>
        Task<User?> GetByUsernameAsync(string username);

        /// <summary>
        /// Looks up a user by their Clerk subject claim (e.g. <c>user_abc123</c>).
        /// </summary>
        /// <param name="clerkId">The Clerk user ID (<c>sub</c> claim value).</param>
        /// <returns>The matching <see cref="User"/>, or <c>null</c> if not found.</returns>
        Task<User?> GetByClerkIdAsync(string clerkId);

        /// <summary>
        /// Returns the existing <see cref="User"/> for the given Clerk ID, or creates and persists
        /// a new one if none exists. This operation is idempotent: concurrent or repeated calls
        /// with the same <paramref name="clerkId"/> will always yield exactly one database record.
        /// </summary>
        /// <param name="clerkId">The Clerk user ID (<c>sub</c> claim value).</param>
        /// <param name="email">The user's email address from Clerk.</param>
        /// <param name="username">
        /// The generated username (typically Clerk first name + last 6 chars of the Clerk ID).
        /// </param>
        /// <returns>The existing or newly created <see cref="User"/>.</returns>
        Task<User> ProvisionClerkUserAsync(string clerkId, string email, string username);
    }
}
