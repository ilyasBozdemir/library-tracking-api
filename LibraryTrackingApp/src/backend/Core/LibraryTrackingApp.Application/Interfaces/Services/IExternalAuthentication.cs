using LibraryTrackingApp.Application.DataTransferObjects;

namespace LibraryTrackingApp.Application.Interfaces.Services
{
    public interface IExternalAuthentication
    {
        Task<TokenDTO> FacebookLoginAsync(string authToken, int accessTokenLifeTime);
        Task<TokenDTO> GoogleLoginAsync(string idToken, int accessTokenLifeTime);
    }
}
