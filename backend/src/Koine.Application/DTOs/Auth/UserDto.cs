// Koine.Application/DTOs/Auth/UserDto.cs
namespace Koine.Application.DTOs.Auth
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string? DisplayName { get; set; }
        public int TotalExperience { get; set; }
    }
}
