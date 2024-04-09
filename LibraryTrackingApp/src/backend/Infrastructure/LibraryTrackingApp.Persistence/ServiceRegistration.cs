using LibraryTrackingApp.Domain.Constants;
using LibraryTrackingApp.Persistence.UnitOfWorks;

namespace LibraryTrackingApp.Persistence;


public static class ServiceRegistration
{
    public static void AddPersistenceRegistration(this IServiceCollection services)
    {
        services.AddDatabaseConfiguration();

        services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

    }

    public static IServiceCollection AddIdentityDbContext(this IServiceCollection services)
    {
        services
            .AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(AppConstant.DefaultConnectionString))
            .AddIdentityDbConfig();
       
        return services;
    }
    public static IServiceCollection AddIdentityDbConfig(this IServiceCollection services)
    {
        //services.AddIdentityApiEndpointsWithConfiguration()
        //    .AddPasswordValidator<CustomPasswordValidation>()
        //    .AddUserValidator<CustomUserValidation>()
        //    .AddErrorDescriber<CustomIdentityErrorDescriber>()
        //    .AddEntityFrameworkStores<AppIdentityDbContext>()
        //    .AddDefaultTokenProviders();

        return services;
    }

    public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services)
    {
        services.AddDbContextPool<AppIdentityDbContext>(
                 options => options.UseSqlServer(AppConstant.DefaultConnectionString,
                     sqlOptions =>
                     {
                         sqlOptions.EnableRetryOnFailure(maxRetryCount: 5,
                         maxRetryDelay: TimeSpan.FromSeconds(15),
                         errorNumbersToAdd: null);
                     })
                     .EnableSensitiveDataLogging()
                 );
        return services;
    }
}