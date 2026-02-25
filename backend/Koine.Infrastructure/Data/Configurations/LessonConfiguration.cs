using Koine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koine.Infrastructure.Data.Configurations
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Slug)
                .HasMaxLength(200)
                .HasDefaultValue(string.Empty)
                .IsRequired();

            builder.Property(l => l.ContentPath)
                .HasMaxLength(500);

            builder.Property(l => l.Title)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(l => l.ContentMarkdown)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.Property(l => l.LessonType)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(l => l.GrammaticalFeatureIdsJson)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.Property(l => l.SyntacticalFeatureIdsJson)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.Property(l => l.VocabularyIdsJson)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasIndex(l => new { l.TrackId, l.LessonIndex })
                .HasDatabaseName("IX_Lessons_Track_LessonIndex");

            builder.HasIndex(l => new { l.TrackId, l.Slug })
                .IsUnique()
                .HasDatabaseName("IX_Lessons_Track_Slug");

            builder.HasOne(l => l.Track)
                .WithMany(t => t.Lessons)
                .HasForeignKey(l => l.TrackId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
