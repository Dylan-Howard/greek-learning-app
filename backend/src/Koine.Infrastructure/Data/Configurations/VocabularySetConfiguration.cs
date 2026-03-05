using Koine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koine.Infrastructure.Data.Configurations
{
    public class VocabularySetConfiguration : IEntityTypeConfiguration<VocabularySet>
    {
        public void Configure(EntityTypeBuilder<VocabularySet> builder)
        {
            builder.ToTable("VocabularySets");

            builder.HasKey(vs => vs.Id);

            builder.Property(vs => vs.Title)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(vs => vs.Description)
                .HasMaxLength(1000)
                .HasDefaultValue(string.Empty)
                .IsRequired();

            builder.Property(vs => vs.Slug)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(vs => vs.IsSystem)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasIndex(vs => vs.Slug)
                .IsUnique()
                .HasDatabaseName("IX_VocabularySets_Slug");

            builder.HasOne(vs => vs.OwnerUser)
                .WithMany(u => u.OwnedVocabularySets)
                .HasForeignKey(vs => vs.OwnerUserId)
                .HasConstraintName("FK_VocabularySets_Users_UserId")
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(vs => vs.OwnerUserId)
                .HasColumnName("UserId");

            builder.HasOne(vs => vs.Book)
                .WithMany()
                .HasForeignKey(vs => vs.BookId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
