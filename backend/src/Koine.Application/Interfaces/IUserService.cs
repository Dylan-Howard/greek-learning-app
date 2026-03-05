// Koine.Application/Interfaces/IUserService.cs
using Koine.Application.DTOs.Auth;
using Koine.Application.DTOs.Users;

namespace Koine.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto?> GetUserByIdAsync(int userId);
        Task<UserDto?> CreateUserAsync(CreateUserDto createDto);
        Task<UserDto?> UpdateUserAsync(int userId, UpdateUserDto updateDto);
        Task<bool> DeleteUserAsync(int userId);

        // User Settings
        Task<List<UserSettingDto>> GetUserSettingsAsync(int userId);
        Task<bool> UpdateUserSettingAsync(int userId, UserSettingDto settingDto);
    }
}
