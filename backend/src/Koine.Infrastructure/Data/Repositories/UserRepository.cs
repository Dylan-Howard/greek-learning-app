using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories;

/// <summary>
/// EF Core implementation of <see cref="IUserRepository"/>.
/// </summary>
public class UserRepository : Repository<User>, IUserRepository
{
    private readonly ILogger<UserRepository> _logger;

    /// <summary>
    /// Initialises a new instance of <see cref="UserRepository"/>.
    /// </summary>
    public UserRepository(KoineDbContext context, ILogger<UserRepository> logger) : base(context)
    {
        _logger = logger;
    }

    /// <inheritdoc/>
    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _dbSet
            .FirstOrDefaultAsync(u => u.Email == email);
    }

    /// <inheritdoc/>
    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await _dbSet
            .FirstOrDefaultAsync(u => u.Username == username);
    }

    /// <inheritdoc/>
    public async Task<User?> GetByClerkIdAsync(string clerkId)
    {
        return await _dbSet
            .FirstOrDefaultAsync(u => u.ClerkId == clerkId);
    }

    /// <inheritdoc/>
    public async Task<User> ProvisionClerkUserAsync(string clerkId, string email, string username)
    {
        var existing = await GetByClerkIdAsync(clerkId);
        if (existing is not null)
        {
            _logger.LogDebug("User with ClerkId {ClerkId} already exists (Id={UserId}); skipping provisioning.", clerkId, existing.Id);
            return existing;
        }

        var user = new User
        {
            ClerkId = clerkId,
            Email = email,
            Username = username,
            PasswordHash = string.Empty,
            CreatedAt = DateTime.UtcNow,
        };

        await _dbSet.AddAsync(user);
        await _context.SaveChangesAsync();

        _logger.LogInformation("Provisioned new user for ClerkId {ClerkId} with Id={UserId}.", clerkId, user.Id);
        return user;
    }
}
