// Koine.API/Middleware/UserProvisioningMiddleware.cs
using System.Security.Claims;
using System.Text.Json;
using Koine.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Koine.API.Middleware;

/// <summary>
/// Middleware that runs after authentication/authorization to ensure every
/// authenticated Clerk user has a corresponding numeric DB record.
/// Stores the resolved numeric user ID in <c>HttpContext.Items["NumericUserId"]</c>
/// so downstream components (e.g. <see cref="Providers.HttpContextCurrentUserProvider"/>)
/// can read it without an additional DB round-trip.
/// </summary>
/// <remarks>Requirements: 10.1, 10.2, 10.3, 10.4</remarks>
public sealed class UserProvisioningMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<UserProvisioningMiddleware> _logger;

    /// <summary>Key used to store the resolved numeric user ID in <see cref="HttpContext.Items"/>.</summary>
    public const string NumericUserIdKey = "NumericUserId";

    /// <inheritdoc cref="UserProvisioningMiddleware"/>
    public UserProvisioningMiddleware(RequestDelegate next, ILogger<UserProvisioningMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    /// <summary>Invokes the middleware for the current HTTP request.</summary>
    public async Task InvokeAsync(HttpContext context, IUserRepository userRepository)
    {
        // Only provision for authenticated requests that carry a Clerk sub claim.
        var clerkId = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (!string.IsNullOrWhiteSpace(clerkId))
        {
            try
            {
                var user = await userRepository.GetByClerkIdAsync(clerkId);

                if (user is null)
                {
                    // Extract email from the Clerk JWT; fall back to a placeholder so
                    // provisioning never fails due to a missing email claim.
                    var email = context.User.FindFirst(ClaimTypes.Email)?.Value
                                ?? $"{clerkId}@provisioned.local";

                    // Username: Clerk first name (if present) + last 6 chars of the Clerk ID.
                    var firstName = context.User.FindFirst(ClaimTypes.GivenName)?.Value
                                    ?? context.User.FindFirst("given_name")?.Value
                                    ?? "user";
                    var suffix = clerkId.Length >= 6 ? clerkId[^6..] : clerkId;
                    var username = $"{firstName.ToLowerInvariant()}_{suffix}";

                    user = await userRepository.ProvisionClerkUserAsync(clerkId, email, username);
                }

                context.Items[NumericUserIdKey] = user.Id;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex,
                    "Database error while provisioning user for Clerk ID {ClerkId}.", clerkId);

                context.Response.StatusCode = StatusCodes.Status503ServiceUnavailable;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(
                    JsonSerializer.Serialize(new { message = "User provisioning failed. Please try again." }));
                return;
            }
        }

        await _next(context);
    }
}
