using System.Security.Claims;
using Koine.Application.Study.Ports;

namespace Koine.API.Providers
{
    public class HttpContextCurrentUserProvider : ICurrentUserProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpContextCurrentUserProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int GetUserId()
        {
            var user = _httpContextAccessor.HttpContext?.User;
            var claimValue = user?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!string.IsNullOrWhiteSpace(claimValue) && int.TryParse(claimValue, out var claimUserId) && claimUserId > 0)
            {
                return claimUserId;
            }

            var headerValue = _httpContextAccessor.HttpContext?.Request?.Headers["X-Dev-User-Id"].FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(headerValue) && int.TryParse(headerValue, out var headerUserId) && headerUserId > 0)
            {
                return headerUserId;
            }

            return 1;
        }
    }
}

