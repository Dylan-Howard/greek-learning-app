// GreekParser.Application/DTOs/Auth/LoginResponseDto.cs
namespace GreekParser.Application.DTOs.Auth
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public UserDto User { get; set; } = null!;
    }
}
