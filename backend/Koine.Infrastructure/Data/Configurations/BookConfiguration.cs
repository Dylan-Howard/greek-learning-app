// GreekParser.Infrastructure/Data/Configurations/BookConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GreekParser.Domain.Entities;

namespace GreekParser.Infrastructure.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            
            builder.HasKey(b => b.Id);
            
            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(255);
            
            builder.Property(b => b.LanguageCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasDefaultValue("grc");
            
            builder.Property(b => b.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");
            
            builder.HasMany(b => b.Chapters)
                .WithOne(c => c.Book)
                .HasForeignKey(c => c.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
