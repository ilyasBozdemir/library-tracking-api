using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace LibraryTrackingApp.Application.Interfaces.Services;

public interface IAuthService : IExternalAuthentication, IInternalAuthentication
{
    Task PasswordResetAsnyc(string usernameOrEmail);
    Task<bool> VerifyResetTokenAsync(string resetToken, string userId);
    Task ForgotPasswordAsync(string usernameOrEmail);
    Task ResetPasswordAsync(string usernameOrEmail, string resetToken, string newPassword);

    Task<SignInResult> SignInAsync(string username, string password, bool isPersistent, bool lockoutOnFailure);


    Task SignOutAsync();


    Task<bool> CheckUserExistence(string userName, string email);
    Task<bool> AuthorizeAsync(string username, string permissionCode);


    Task<AuthenticationResult> TwoFactorLoginAsync(Guid userId, string twoFactorCode);
    Task<List<string>> GenerateRecoveryCodesAsync();
    Task<bool> ValidateRecoveryCodeAsync(Guid userId, string recoveryCode);
}
