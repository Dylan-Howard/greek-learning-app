// Koine.Infrastructure/Data/Configurations/SessionCardConfiguration.cs
using Koine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koine.Infrastructure.Data.Configurations
{
    public class SessionCardConfiguration : IEntityTypeConfiguration<SessionCard>
    {
        public void Configure(EntityTypeBuilder<SessionCard> builder)
        {
            builder.ToTable("SessionCards");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Mode)
                .HasConversion<int>();

            builder.Property(c => c.Direction)
                .HasConversion<int>();
        }
    }
}
