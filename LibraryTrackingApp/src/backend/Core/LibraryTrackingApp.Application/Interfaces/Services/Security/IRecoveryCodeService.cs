namespace LibraryTrackingApp.Application.Interfaces.Services.Security;

public interface IRecoveryCodeService
{
    Task<List<string>> GenerateRecoveryCodesAsync();
    Task<bool> ValidateRecoveryCodeAsync(Guid userId, string recoveryCode);
}
