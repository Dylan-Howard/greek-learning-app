// GreekParser.Infrastructure/Data/Configurations/LessonCompletionConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GreekParser.Domain.Entities;

namespace GreekParser.Infrastructure.Data.Configurations
{
    public class LessonCompletionConfiguration : IEntityTypeConfiguration<LessonCompletion>
    {
        public void Configure(EntityTypeBuilder<LessonCompletion> builder)
        {
            builder.ToTable("LessonCompletions");
            
            builder.HasKey(lc => lc.Id);
            
            builder.Property(lc => lc.CompletedAt)
                .HasDefaultValueSql("GETUTCDATE()");
            
            builder.HasIndex(lc => new { lc.UserId, lc.LessonId })
                .IsUnique()
                .HasDatabaseName("IX_LessonCompletions_User_Lesson");
            
            builder.HasOne(lc => lc.User)
                .WithMany(u => u.LessonCompletions)
                .HasForeignKey(lc => lc.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(lc => lc.Lesson)
                .WithMany(l => l.Completions)
                .HasForeignKey(lc => lc.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
