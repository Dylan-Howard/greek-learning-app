// Koine.Infrastructure/Data/Configurations/StudySessionConfiguration.cs
using System.Text.Json;
using Koine.Domain.Entities;
using Koine.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koine.Infrastructure.Data.Configurations
{
    public class StudySessionConfiguration : IEntityTypeConfiguration<StudySession>
    {
        public void Configure(EntityTypeBuilder<StudySession> builder)
        {
            builder.ToTable("StudySessions");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Config)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<SessionConfig>(v, (JsonSerializerOptions?)null) ?? new SessionConfig())
                .HasColumnName("ConfigJson")
                .HasColumnType("nvarchar(512)");

            builder.HasMany(s => s.Cards)
                .WithOne()
                .HasForeignKey(c => c.SessionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
