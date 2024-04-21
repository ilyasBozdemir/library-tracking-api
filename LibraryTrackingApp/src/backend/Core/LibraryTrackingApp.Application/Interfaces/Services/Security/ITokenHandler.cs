using PreAccountingBE.Application.Features.DTOs.User;
using System.Security.Claims;

namespace LibraryTrackingApp.Application.Interfaces.Services.Security;

public interface ITokenHandler
{
    TokenDTO GenerateToken(UserDTO user);
    bool ValidateToken(string token);
    IEnumerable<Claim> GetClaimsFromJwt(string jwtToken);
    IEnumerable<Claim> GetClaimsFromHttpContext();
}