// GreekParser.Infrastructure/Data/Configurations/UserProgressConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GreekParser.Domain.Entities;

namespace GreekParser.Infrastructure.Data.Configurations
{
    public class UserProgressConfiguration : IEntityTypeConfiguration<UserProgress>
    {
        public void Configure(EntityTypeBuilder<UserProgress> builder)
        {
            builder.ToTable("UserProgresses");
            
            builder.HasKey(up => up.Id);
            
            builder.Property(up => up.CompletedLessonIdsJson)
                .IsRequired()
                .HasColumnType("nvarchar(max)")
                .HasDefaultValue("[]");
            
            builder.Property(up => up.GrammaticalFeatureProgressJson)
                .IsRequired()
                .HasColumnType("nvarchar(max)")
                .HasDefaultValue("{}");
            
            builder.Property(up => up.SyntacticalFeatureProgressJson)
                .IsRequired()
                .HasColumnType("nvarchar(max)")
                .HasDefaultValue("{}");
            
            builder.Property(up => up.VocabularyProgressJson)
                .IsRequired()
                .HasColumnType("nvarchar(max)")
                .HasDefaultValue("{}");
            
            builder.Property(up => up.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");
            
            builder.HasIndex(up => up.UserId)
                .IsUnique()
                .HasDatabaseName("IX_UserProgresses_UserId");
            
            builder.HasOne(up => up.User)
                .WithOne(u => u.Progress)
                .HasForeignKey<UserProgress>(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
