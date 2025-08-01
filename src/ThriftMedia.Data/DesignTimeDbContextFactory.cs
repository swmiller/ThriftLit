using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ThriftMedia.Data.Models;

namespace ThriftMedia.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ThriftMediaDbContext>
{
    public ThriftMediaDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ThriftMediaDbContext>();
        
        // Use steve-miller SQL Server instance for design-time operations
        // You can override this with --connection parameter or environment variable
        var connectionString = "Server=steve-miller;Database=ThriftMediaDb;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true";
        
        optionsBuilder.UseSqlServer(connectionString);
        
        return new ThriftMediaDbContext(optionsBuilder.Options);
    }
}
