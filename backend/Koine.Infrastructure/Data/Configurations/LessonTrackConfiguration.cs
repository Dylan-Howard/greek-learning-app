using Koine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koine.Infrastructure.Data.Configurations
{
    public class LessonTrackConfiguration : IEntityTypeConfiguration<LessonTrack>
    {
        public void Configure(EntityTypeBuilder<LessonTrack> builder)
        {
            builder.ToTable("LessonTracks");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Slug)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.Title)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.Description)
                .HasMaxLength(1000)
                .HasDefaultValue(string.Empty)
                .IsRequired();

            builder.Property(t => t.SortOrder)
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(t => t.IsSystem)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(t => t.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasIndex(t => t.Slug)
                .IsUnique()
                .HasDatabaseName("IX_LessonTracks_Slug");
        }
    }
}
