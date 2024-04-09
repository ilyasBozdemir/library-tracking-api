using LibraryTrackingApp.Domain.Constants;

namespace LibraryTrackingApp.Persistence.Design;

public class DesignTimeAppIdentityDbContext : IDesignTimeDbContextFactory<AppIdentityDbContext>
{
    public AppIdentityDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppIdentityDbContext>();
        optionsBuilder.UseSqlServer(AppConstant.DefaultConnectionString);
        return new AppIdentityDbContext(optionsBuilder.Options);
    }
}