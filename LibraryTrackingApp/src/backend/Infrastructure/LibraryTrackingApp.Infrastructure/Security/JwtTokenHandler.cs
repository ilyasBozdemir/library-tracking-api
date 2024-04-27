using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Application.Interfaces.Services.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrackingApp.Infrastructure.Security;

public class JwtTokenHandler : ITokenHandler
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    private string secretKey;
    private string issuer;
    private string audience;
    private string subject;
    private string accessTokenExpirationMinutes;
    private string refreshTokenExpirationMinutes;


    public JwtTokenHandler()
    {

    }

    public TokenDTO GenerateToken(UserDTO user)
    {
        // buralar doldurulcktır dbden.
        secretKey = "";
        issuer = ""; //kimlik doğrulama sağlayıcısını temsil eder
        audience = ""; //kimin tarafından kullanılcağı
        subject = ""; //kullanıcının benzersiz kimliği

        accessTokenExpirationMinutes = "15";
        refreshTokenExpirationMinutes = (15 * 1.5).ToString();


        var tokenHandler = new JwtSecurityTokenHandler();
        var claims = GenerateUserClaims(user);
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

        var accessTokenExpiry = DateTime.Now.AddMinutes(int.Parse(accessTokenExpirationMinutes ?? string.Empty));
        var refreshTokenExpiry = DateTime.Now.AddMinutes(int.Parse(refreshTokenExpirationMinutes ?? string.Empty));

        var accessToken = new JwtSecurityToken(issuer, audience, claims, expires: accessTokenExpiry, signingCredentials: signIn);
        var refreshToken = new JwtSecurityToken(issuer, audience, new List<Claim>(), expires: refreshTokenExpiry, signingCredentials: signIn);

        return new TokenDTO
        {
            AccessToken = tokenHandler.WriteToken(accessToken),
            AccessTokenExpiry = accessTokenExpiry,
            RefreshToken = tokenHandler.WriteToken(refreshToken),
            RefreshTokenExpiry = refreshTokenExpiry
        };
    }

    public Claim[] GenerateUserClaims(UserDTO user)
    {
        DateTimeOffset issuedAt = DateTimeOffset.UtcNow;

        /*
         * UserDtodan gelicek user'dan veritabanında ki user'ı alıp burda
         * rollerini de eklencek
         * scope kısmını da yazıcağız companyProfile bazlı
         * olarak eklencek.
         */

        var roles = new string[] { "role1", "role2" };// roller user dtodan gelebilir.

        var baseClaims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new Claim(JwtRegisteredClaimNames.Iss, issuer),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(
                JwtRegisteredClaimNames.Iat,
                issuedAt.ToUnixTimeSeconds().ToString(),
                ClaimValueTypes.Integer64
            ),
            new Claim("scope", null),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(ClaimTypes.Role, string.Join(", ", roles))
        };

        return baseClaims.ToArray();
    }

    public bool ValidateToken(string token)
    {
        if (token == null)
            return false;

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(secretKey);
        try
        {
            tokenHandler.ValidateToken(
                token,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                },
                out SecurityToken validatedToken
            );

            var jwtToken = (JwtSecurityToken)validatedToken;
            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Claim> GetClaimsFromJwt(string jwtToken)
    {
        var handler = new JwtSecurityTokenHandler();

        var token = handler.ReadJwtToken(jwtToken);

        var claims = new List<Claim>(token.Claims);

        return claims;
    }

    public IEnumerable<Claim> GetClaimsFromHttpContext()
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext != null)
        {
            var authorizationHeader = httpContext.Request.Headers["Authorization"].FirstOrDefault();
            if (
                !string.IsNullOrEmpty(authorizationHeader)
                && authorizationHeader.StartsWith("Bearer ")
            )
            {
                var jwtToken = authorizationHeader.Substring("Bearer ".Length);

                return GetClaimsFromJwt(jwtToken);
            }
        }

        return new List<Claim>();
    }

}

