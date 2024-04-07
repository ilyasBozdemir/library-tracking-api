using LibraryTrackingApp.Persistence.Contexts;
using LibraryTrackingApp.Persistence.Extensions;
using LibraryTrackingApp.Persistence.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LibraryTrackingApp.Domain.Entities.Identity;
using LibraryTrackingApp.Persistence.Configurations;
using Microsoft.AspNetCore.Identity;

namespace LibraryTrackingApp.Persistence;


public static class ServiceRegistration
{
    public static void AddPersistenceRegistration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabaseConfiguration(configuration);
    }

    public static IServiceCollection AddIdentityDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
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

    public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<AppIdentityDbContext>(
                 options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                     sqlOptions =>
                     {
                         sqlOptions.EnableRetryOnFailure(maxRetryCount: 5,
                         maxRetryDelay: TimeSpan.FromSeconds(3),
                         errorNumbersToAdd: null);
                     })
                     .EnableSensitiveDataLogging()
                 );

        return services;
    }
}