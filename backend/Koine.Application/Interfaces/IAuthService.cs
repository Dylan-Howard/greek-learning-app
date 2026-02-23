// Koine.Application/Interfaces/IAuthService.cs
using Koine.Application.DTOs.Auth;

namespace Koine.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginDto);
        Task<UserDto?> RegisterAsync(string email, string username, string password);
        Task<UserDto?> GetUserFromTokenAsync(string token);
    }
}
