// GreekParser.Application/DTOs/Auth/UserDto.cs
namespace GreekParser.Application.DTOs.Auth
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string? DisplayName { get; set; }
    }
}
