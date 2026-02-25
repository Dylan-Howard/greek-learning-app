using Koine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koine.Infrastructure.Data.Configurations
{
    public class VocabularySetItemConfiguration : IEntityTypeConfiguration<VocabularySetItem>
    {
        public void Configure(EntityTypeBuilder<VocabularySetItem> builder)
        {
            builder.ToTable("VocabularySetItems");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.MasteryLevel)
                .HasDefaultValue(0)
                .IsRequired();

            builder.HasIndex(i => new { i.VocabularySetId, i.VocabularyId })
                .IsUnique()
                .HasDatabaseName("IX_VocabularySetItems_Set_Vocabulary");

            builder.HasOne(i => i.VocabularySet)
                .WithMany(s => s.Items)
                .HasForeignKey(i => i.VocabularySetId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(i => i.Vocabulary)
                .WithMany()
                .HasForeignKey(i => i.VocabularyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
