using System.Security.Claims;
using Koine.API.Middleware;
using Koine.Application.Study.Ports;

namespace Koine.API.Providers
{
    /// <summary>
    /// Resolves the current user's numeric database ID from <see cref="HttpContext.Items"/>,
    /// where <see cref="UserProvisioningMiddleware"/> stores it after mapping the Clerk <c>sub</c>
    /// claim to a DB record.
    /// </summary>
    public class HttpContextCurrentUserProvider : ICurrentUserProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        // Request-scoped cache: populated on first call, reused for subsequent calls
        // within the same HTTP request.
        private int? _cachedUserId;

        /// <summary>
        /// Initialises a new instance of <see cref="HttpContextCurrentUserProvider"/>.
        /// </summary>
        /// <param name="httpContextAccessor">Accessor for the current <see cref="HttpContext"/>.</param>
        public HttpContextCurrentUserProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Returns the numeric database user ID for the current request.
        /// The value is read from <c>HttpContext.Items["NumericUserId"]</c> (set by
        /// <see cref="UserProvisioningMiddleware"/>) and cached for the lifetime of the request.
        /// </summary>
        /// <returns>The numeric database user ID.</returns>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown when no numeric user ID is present in <c>HttpContext.Items</c>.
        /// </exception>
        public int GetUserId()
        {
            if (_cachedUserId.HasValue)
                return _cachedUserId.Value;

#if DEBUG
            // Dev-only fallback: allow overriding the user via a request header so that
            // Swagger / NSwag UI can be used without a real Clerk JWT.
            var headerValue = _httpContextAccessor.HttpContext?.Request?.Headers["X-Dev-User-Id"].FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(headerValue) && int.TryParse(headerValue, out var headerUserId) && headerUserId > 0)
            {
                _cachedUserId = headerUserId;
                return _cachedUserId.Value;
            }
#endif

            var items = _httpContextAccessor.HttpContext?.Items;
            if (items is not null && items.TryGetValue(UserProvisioningMiddleware.NumericUserIdKey, out var raw) && raw is int numericId)
            {
                _cachedUserId = numericId;
                return _cachedUserId.Value;
            }

            // Provide a descriptive message that includes the Clerk ID when available.
            var clerkId = _httpContextAccessor.HttpContext?.User
                              .FindFirst(ClaimTypes.NameIdentifier)?.Value
                          ?? "<unknown>";

            throw new UnauthorizedAccessException($"No user record found for Clerk ID: {clerkId}");
        }
    }
}
