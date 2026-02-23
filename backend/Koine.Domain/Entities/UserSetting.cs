namespace Koine.Domain.Entities
{
    public class UserSetting
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SettingName { get; set; } = string.Empty;
        public string SettingValue { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public virtual User User { get; set; } = null!;
    }
}
