namespace LibraryTrackingApp.Persistence.Design;

public class DesignTimeAppIdentityDbContext : IDesignTimeDbContextFactory<AppIdentityDbContext>
{
    private readonly IConfiguration _configuration;

    public DesignTimeAppIdentityDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public AppIdentityDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppIdentityDbContext>();

        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlServer(connectionString);
        return new AppIdentityDbContext(optionsBuilder.Options);
    }
}