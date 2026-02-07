// GreekParser.Application/Interfaces/IUserService.cs
namespace GreekParser.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto?> GetUserByIdAsync(int userId);
        Task<UserDto?> UpdateUserAsync(int userId, UpdateUserDto updateDto);
        Task<bool> DeleteUserAsync(int userId);
    }
}
