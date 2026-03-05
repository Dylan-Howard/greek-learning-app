using Koine.Domain.Entities;

using Koine.Domain.Entities;

namespace Koine.Application.Interfaces.Repositories
{
    public interface IUserSettingRepository : IRepository<UserSetting>
    {
        Task<List<UserSetting>> GetByUserIdAsync(int userId);
        Task<UserSetting?> GetByUserAndNameAsync(int userId, string settingName);
    }
}
