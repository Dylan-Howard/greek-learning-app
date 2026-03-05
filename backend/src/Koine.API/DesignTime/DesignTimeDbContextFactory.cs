// Koine.API/DesignTime/DesignTimeDbContextFactory.cs
using Koine.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Koine.API.DesignTime
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<KoineDbContext>
    {
        public KoineDbContext CreateDbContext(string[] args)
        {
            var connection = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")
                ?? "Server=localhost,1433;Database=Koine;User Id=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=True;";

            var optionsBuilder = new DbContextOptionsBuilder<KoineDbContext>();
            optionsBuilder.UseSqlServer(connection, b => b.MigrationsAssembly("Koine.Infrastructure"));

            return new KoineDbContext(optionsBuilder.Options);
        }
    }
}
