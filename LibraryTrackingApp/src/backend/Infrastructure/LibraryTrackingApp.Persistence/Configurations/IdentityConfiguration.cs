using LibraryTrackingApp.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace LibraryTrackingApp.Persistence.Configurations;

public static class IdentityConfiguration
{
    public static PasswordOptions PasswordOptions { get; private set; }
    public static SignInOptions SignInOptions { get; private set; }
    public static LockoutOptions LockoutOptions { get; private set; }
    public static UserOptions UserOptions { get; private set; }
    public static ClaimsIdentityOptions ClaimsIdentityOptions { get; private set; }
    public static TokenOptions TokenOptions { get; private set; }
    public static StoreOptions StoreOptions { get; set; }

    static IdentityConfiguration()
    {
        PasswordOptions = new PasswordOptions
        {
            RequiredLength = 12,
            RequiredUniqueChars = 3,
            RequireNonAlphanumeric = true,
            RequireLowercase = true,
            RequireUppercase = true,
            RequireDigit = true
        };

        SignInOptions = new SignInOptions
        {
            RequireConfirmedEmail = true,
            RequireConfirmedPhoneNumber = true,
            RequireConfirmedAccount = true
        };

        LockoutOptions = new LockoutOptions
        {
            AllowedForNewUsers = true,
            MaxFailedAccessAttempts = 5,
            DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15)
        };

        UserOptions = new UserOptions
        {
            AllowedUserNameCharacters =
                "abcçdefghıijklmnoçpqrsştuüvwxyzABCÇDEFGHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789-._@+'#!/^%{}*",
            RequireUniqueEmail = true
        };

        ClaimsIdentityOptions = new ClaimsIdentityOptions
        {
            RoleClaimType = ClaimTypes.Role,
            UserNameClaimType = ClaimTypes.Name,
            UserIdClaimType = ClaimTypes.NameIdentifier,
            EmailClaimType = ClaimTypes.Email,
            SecurityStampClaimType = "AspNet.Identity.SecurityStamp"
        };

        TokenOptions = new TokenOptions
        {
            ProviderMap = new Dictionary<string, TokenProviderDescriptor>
        {
            {
                "Default",
                new TokenProviderDescriptor(typeof(DataProtectorTokenProvider<AppUser>))
            },
            {
                "Email",
                new TokenProviderDescriptor(typeof(EmailTokenProvider<AppUser>))
            },
        },
            EmailConfirmationTokenProvider = "Default",
            PasswordResetTokenProvider = "Default",
            ChangeEmailTokenProvider = "Default",
            ChangePhoneNumberTokenProvider = "Phone",
            AuthenticatorTokenProvider = "Authenticator",
            AuthenticatorIssuer = "Microsoft.AspNetCore.Identity.UI"
        };

        StoreOptions = new StoreOptions
        {

        };

    }
}
