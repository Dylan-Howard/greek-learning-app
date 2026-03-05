// Koine.Infrastructure/Data/Configurations/TranslationUnitConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Koine.Domain.Entities;

namespace Koine.Infrastructure.Data.Configurations
{
    public class TranslationUnitConfiguration : IEntityTypeConfiguration<TranslationUnit>
    {
        public void Configure(EntityTypeBuilder<TranslationUnit> builder)
        {
            builder.ToTable("TranslationUnits");
            
            builder.HasKey(tu => tu.Id);
            
            builder.Property(tu => tu.OriginalUnitPath)
                .IsRequired();
            
            builder.Property(tu => tu.TranslatedText)
                .IsRequired();
            
            builder.HasOne(tu => tu.Translation)
                .WithMany(t => t.TranslationUnits)
                .HasForeignKey(tu => tu.TranslationId)
                .OnDelete(DeleteBehavior.NoAction); // Fix for multiple cascade paths

            builder.HasOne(tu => tu.Chapter)
                .WithMany(c => c.TranslationUnits)
                .HasForeignKey(tu => tu.ChapterId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
