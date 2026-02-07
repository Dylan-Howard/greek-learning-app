// GreekParser.Application/Interfaces/IAuthService.cs
namespace GreekParser.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginDto);
        Task<UserDto?> RegisterAsync(string email, string username, string password);
        Task<UserDto?> GetUserFromTokenAsync(string token);
    }
}
