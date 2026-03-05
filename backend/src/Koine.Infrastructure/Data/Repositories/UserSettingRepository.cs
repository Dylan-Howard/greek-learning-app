using Microsoft.EntityFrameworkCore;
using Koine.Application.Interfaces.Repositories;
using Koine.Domain.Entities;
using Koine.Infrastructure.Data.Context;

namespace Koine.Infrastructure.Data.Repositories
{
    public class UserSettingRepository : Repository<UserSetting>, IUserSettingRepository
    {
        public UserSettingRepository(KoineDbContext context) : base(context)
        {
        }

        public async Task<List<UserSetting>> GetByUserIdAsync(int userId)
        {
            return await _dbSet
                .Where(s => s.UserId == userId)
                .ToListAsync();
        }

        public async Task<UserSetting?> GetByUserAndNameAsync(int userId, string settingName)
        {
            return await _dbSet
                .FirstOrDefaultAsync(s => s.UserId == userId && s.SettingName == settingName);
        }
    }
}
