using LibraryTrackingApp.Domain.Entities.Identity;
using LibraryTrackingApp.Persistence.Configurations;
using LibraryTrackingApp.Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryTrackingApp.Persistence.Extensions;

public static class IdentityExtensions
{

    public static IdentityBuilder AddIdentityCoreWithConfiguration<TUser, TRole>(
        this IServiceCollection services,
        Action<IdentityOptions> configureOptions = null)
        where TUser : IdentityUser
        where TRole : IdentityRole
    {
        return services.AddIdentityCore<TUser>(options =>
        {
            configureOptions?.Invoke(options);
            ConfigureIdentityOptions(options);
        })
        .AddEntityFrameworkStores<AppIdentityDbContext>()
        .AddDefaultTokenProviders();
    }

    public static IdentityBuilder AddIdentityWithConfiguration(
        this IServiceCollection services,
        Action<IdentityOptions> configureOptions = null)
    {
        return services.AddIdentity<AppUser, AppRole>(options =>
        {
            configureOptions?.Invoke(options);
            ConfigureIdentityOptions(options);
        })
        .AddEntityFrameworkStores<AppIdentityDbContext>()
        .AddDefaultTokenProviders();
    }

    public static IdentityBuilder AddIdentityApiEndpointsWithConfiguration(
          this IServiceCollection services,
          Action<IdentityOptions> configureOptions = null)
    {


        return services.AddIdentityApiEndpoints<AppUser>(options =>
        {
            configureOptions?.Invoke(options);
            ConfigureIdentityOptions(options);
        });

    }

    private static void ConfigureIdentityOptions(IdentityOptions options)
    {
        options.Password = IdentityConfiguration.PasswordOptions;
        options.Stores = IdentityConfiguration.StoreOptions;
        options.SignIn = IdentityConfiguration.SignInOptions;
        options.Lockout = IdentityConfiguration.LockoutOptions;
        options.User = IdentityConfiguration.UserOptions;
        options.ClaimsIdentity = IdentityConfiguration.ClaimsIdentityOptions;
        options.Tokens = IdentityConfiguration.TokenOptions;
    }
}
