// GreekParser.Application/Interfaces/IProgressService.cs
namespace GreekParser.Application.Interfaces
{
    public interface IProgressService
    {
        Task<UserProgressDto?> GetUserProgressAsync(int userId);
        Task<bool> UpdateProgressAsync(int userId, UserProgressDto progressDto);
    }
}
