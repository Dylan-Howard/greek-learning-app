// GreekParser.Infrastructure/Data/Configurations/ChapterConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GreekParser.Domain.Entities;

namespace GreekParser.Infrastructure.Data.Configurations
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("Chapters");
            
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.ChapterIndex)
                .IsRequired();
            
            builder.Property(c => c.Title)
                .HasMaxLength(255);
            
            builder.Property(c => c.UnitTreeJson)
                .IsRequired()
                .HasColumnType("nvarchar(max)");
            
            builder.Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");
            
            builder.HasIndex(c => new { c.BookId, c.ChapterIndex })
                .IsUnique()
                .HasDatabaseName("IX_Chapters_Book_Index");
            
            builder.HasOne(c => c.Book)
                .WithMany(b => b.Chapters)
                .HasForeignKey(c => c.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
