// GreekParser.Application/Services/UserService.cs
using GreekParser.Application.DTOs.Auth;
using GreekParser.Application.DTOs.Users;
using GreekParser.Application.Interfaces;

namespace GreekParser.Application.Services
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
    }
}
