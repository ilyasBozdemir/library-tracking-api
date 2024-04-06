using LibraryTrackingApp.Domain.Entities.Identity;
using LibraryTrackingApp.Persistence.Contexts;
using LibraryTrackingApp.Persistence.Extensions;
using LibraryTrackingApp.Persistence.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryTrackingApp.Persistence;


public static class ServiceRegistration
{
    public static void AddPersistenceRegistration(this IServiceCollection services)
    {
        services.AddDatabaseConfiguration();


     
    }

    public static IServiceCollection AddIdentityDbContext(this IServiceCollection services)
    {
        var connString = @"Server=DESKTOP-R4UP5K6\SQLEXPRESS;Database=AppIdentityDb;Integrated Security=True;TrustServerCertificate=True;";
        services
            .AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(connString))
            .AddIdentityDbConfig();
        return services;
    }
    public static IServiceCollection AddIdentityDbConfig(this IServiceCollection services)
    {
        services.AddIdentityApiEndpointsWithConfiguration()
            .AddPasswordValidator<CustomPasswordValidation>()
            .AddUserValidator<CustomUserValidation>()
            .AddErrorDescriber<CustomIdentityErrorDescriber>()
            .AddEntityFrameworkStores<AppIdentityDbContext>()
            .AddDefaultTokenProviders();

        return services;
    }

    public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services)
    {
        services.AddDbContextPool<AppIdentityDbContext>(
                 options => options.UseSqlServer(@"Server=DESKTOP-R4UP5K6\SQLEXPRESS;Database=AppIdentityDb;Integrated Security=True;TrustServerCertificate=True;",
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