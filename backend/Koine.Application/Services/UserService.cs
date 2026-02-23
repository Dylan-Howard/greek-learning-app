// Koine.Application/Services/UserService.cs
using Koine.Application.DTOs.Auth;
using Koine.Application.DTOs.Users;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;
using System.Text;

namespace Koine.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _unitOfWork.Users.GetAllAsync();

            return users.Select(u => new UserDto
            {
                Id = u.Id,
                Email = u.Email,
                Username = u.Username,
                DisplayName = u.DisplayName
            }).ToList();
        }

        public async Task<UserDto?> GetUserByIdAsync(int userId)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(userId);
            if (user == null) return null;

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.Username,
                DisplayName = user.DisplayName
            };
        }

        public async Task<UserDto?> CreateUserAsync(CreateUserDto createDto)
        {
            if (string.IsNullOrEmpty(createDto.Email) || string.IsNullOrEmpty(createDto.Username) || string.IsNullOrEmpty(createDto.Password))
                return null;

            // Check if user already exists
            var existingUser = await _unitOfWork.Users.GetByEmailAsync(createDto.Email);
            if (existingUser != null) return null;

            var existingUsername = await _unitOfWork.Users.GetByUsernameAsync(createDto.Username);
            if (existingUsername != null) return null;

            var user = new User
            {
                Email = createDto.Email,
                Username = createDto.Username,
                PasswordHash = HashPassword(createDto.Password),
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.SaveChangesAsync();

            // Create initial progress record
            await _unitOfWork.UserProgress.GetOrCreateByUserIdAsync(user.Id);

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.Username,
                DisplayName = user.DisplayName
            };
        }

        public async Task<UserDto?> UpdateUserAsync(int userId, UpdateUserDto updateDto)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(userId);
            if (user == null) return null;

            if (!string.IsNullOrWhiteSpace(updateDto.Email))
                user.Email = updateDto.Email;
            
            if (!string.IsNullOrWhiteSpace(updateDto.Username))
                user.Username = updateDto.Username;
            
            if (updateDto.DisplayName != null)
                user.DisplayName = updateDto.DisplayName;

            await _unitOfWork.Users.UpdateAsync(user);
            await _unitOfWork.SaveChangesAsync();

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.Username,
                DisplayName = user.DisplayName
            };
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(userId);
            if (user == null) return false;

            await _unitOfWork.Users.DeleteAsync(user);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<List<UserSettingDto>> GetUserSettingsAsync(int userId)
        {
            var settings = await _unitOfWork.UserSettings.GetByUserIdAsync(userId);
            return settings.Select(s => new UserSettingDto
            {
                SettingName = s.SettingName,
                SettingValue = s.SettingValue
            }).ToList();
        }

        public async Task<bool> UpdateUserSettingAsync(int userId, UserSettingDto settingDto)
        {
            if (string.IsNullOrEmpty(settingDto.SettingName)) return false;

            var setting = await _unitOfWork.UserSettings.GetByUserAndNameAsync(userId, settingDto.SettingName);
            if (setting != null)
            {
                setting.SettingValue = settingDto.SettingValue ?? string.Empty;
                setting.UpdatedAt = DateTime.UtcNow;
                await _unitOfWork.UserSettings.UpdateAsync(setting);
            }
            else
            {
                setting = new UserSetting
                {
                    UserId = userId,
                    SettingName = settingDto.SettingName,
                    SettingValue = settingDto.SettingValue ?? string.Empty,
                    UpdatedAt = DateTime.UtcNow
                };
                await _unitOfWork.UserSettings.AddAsync(setting);
            }

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        private string HashPassword(string password)
        {
            // TODO: Implement proper password hashing (BCrypt, Argon2, etc.)
            // This is just a placeholder to match AuthService
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }
    }
}
