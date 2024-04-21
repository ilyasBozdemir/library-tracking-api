using LibraryTrackingApp.Application.Interfaces.Services.Security;
using LibraryTrackingApp.Application.Interfaces.Services;
using LibraryTrackingApp.Domain.Constants;
using LibraryTrackingApp.Persistence.UnitOfWorks;
using LibraryTrackingApp.Persistence.Services;

namespace LibraryTrackingApp.Persistence;


public static class ServiceRegistration
{
    public static void AddPersistenceRegistration(this IServiceCollection services)
    {

        services.AddDatabaseConfiguration();

        services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserService, UserService>();

    }

    public static IServiceCollection AddIdentityDbContext(this IServiceCollection services)
    {
        services
            .AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(AppConstant.DefaultConnectionString))
            .AddIdentityWithConfiguration()
            .AddEntityFrameworkStores<AppIdentityDbContext>()
            .AddUserManager<UserManager<AppUser>>()
            .AddSignInManager<SignInManager<AppUser>>()
            .AddDefaultTokenProviders()
            .AddPasswordValidator<CustomPasswordValidation>()
            .AddUserValidator<CustomUserValidation>()
            .AddErrorDescriber<CustomIdentityErrorDescriber>();


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
        services.AddIdentityDbContext();

        return services;
    }
}