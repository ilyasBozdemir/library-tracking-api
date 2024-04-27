using LibraryTrackingApp.Application.DataTransferObjects;
using Microsoft.AspNetCore.Identity;

namespace LibraryTrackingApp.Application.Interfaces.Services
{
    public interface IInternalAuthentication
    {
        Task<TokenDTO> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
        Task<TokenDTO> RefreshTokenLoginAsync(string refreshToken);
    }
}
