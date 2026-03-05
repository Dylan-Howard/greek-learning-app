// Koine.Infrastructure/Data/Configurations/UserCardProgressConfiguration.cs
using Koine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koine.Infrastructure.Data.Configurations
{
    public class UserCardProgressConfiguration : IEntityTypeConfiguration<UserCardProgress>
    {
        public void Configure(EntityTypeBuilder<UserCardProgress> builder)
        {
            builder.ToTable("UserCardProgress");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.State)
                .HasConversion<int>();

            builder.HasIndex(x => new { x.UserId, x.VocabularyId })
                .IsUnique()
                .HasDatabaseName("UQ_UserCardProgress_UserId_VocabularyId");

            builder.HasIndex(x => new { x.UserId, x.NextReviewDate })
                .HasDatabaseName("IX_UserCardProgress_Due");
        }
    }
}
