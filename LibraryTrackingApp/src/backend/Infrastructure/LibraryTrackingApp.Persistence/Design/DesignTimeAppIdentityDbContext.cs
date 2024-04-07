using LibraryTrackingApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LibraryTrackingApp.Persistence.Design;

public class DesignTimeAppIdentityDbContext : IDesignTimeDbContextFactory<AppIdentityDbContext>
{
    public AppIdentityDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppIdentityDbContext>();


        optionsBuilder.UseSqlServer(@"Server=DESKTOP-R4UP5K6\SQLEXPRESS;Database=AppIdentityDb;Integrated Security=True;TrustServerCertificate=True;");
        return new AppIdentityDbContext(optionsBuilder.Options);
    }
}