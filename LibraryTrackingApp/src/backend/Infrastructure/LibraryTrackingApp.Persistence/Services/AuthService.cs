using AutoMapper;
using LibraryTrackingApp.Application.DTOs;
using LibraryTrackingApp.Application.Interfaces.Services;
using LibraryTrackingApp.Application.Interfaces.Services.Messaging;
using LibraryTrackingApp.Application.Interfaces.Services.Security;
using LibraryTrackingApp.Domain.Constants;
using LibraryTrackingApp.Domain.Exceptions;
using Microsoft.Identity.Client;
using PreAccountingBE.Application.Features.DTOs.User;
using System.Security.Claims;

namespace LibraryTrackingApp.Persistence.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    private readonly ITokenHandler _tokenHandler;
    private readonly IUserService _userService;
    private readonly IMailService _mailService;
    private readonly IRecoveryCodeService _recoveryCodeService;

    private readonly IMapper _mapper;


    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AuthService

        (UserManager<AppUser> userManager,
        SignInManager<AppUser> signInManager,
        HttpClient httpClient,
        IConfiguration configuration,
        ITokenHandler tokenHandler,
        IUserService userService,
        IMapper mapper)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        _tokenHandler = tokenHandler;
        _userService = userService;
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
    }


    public async Task<TokenDTO> HandleExternalLoginAsync(ExternalLoginInfo info, int accessTokenLifeTime = 900)
    {
        if (info == null)
        {
            throw new Exception("External login info is missing.");
        }

        var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

        switch (result)
        {
            case { Succeeded: true }:
                var user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
                var createUserDto = _mapper.Map<UserDTO>(user);
                var token = _tokenHandler.GenerateToken(createUserDto);
                return token;

            case { IsLockedOut: true }:
                throw new Exception("User account is locked.");

            case { IsNotAllowed: true }:
                throw new Exception("User is not allowed to sign in.");

            default:
                throw new Exception("Unhandled result case.");
        }

        var email = info.Principal.FindFirstValue(ClaimTypes.Email);
        var newUser = new AppUser
        {
            UserName = email,
            Email = email,

        };
        var identityResult = await _userManager.CreateAsync(newUser);

        if (identityResult.Succeeded)
        {
            await _userManager.AddLoginAsync(newUser, info);
            var createUserDto = _mapper.Map<UserDTO>(newUser);
            var token = _tokenHandler.GenerateToken(createUserDto);
            return token;
        }
        else
            throw new Exception("User registration failed.");

    }


    private async Task<TokenDTO> CreateUserExternalAsync(AppUser? user, string email, string name, UserLoginInfo info, int accessTokenLifeTime)
    {
        bool isExternalRegistration = user != null;

        if (!isExternalRegistration)
        {
            user = await _userManager.FindByEmailAsync(user.Email);
            if (user == null)
            {
                user = new AppUser
                {
                    Id = Guid.NewGuid(),
                    Email = user.Email,
                    UserName = user.UserName,
                    Name = user.Name,
                    Surname = user.Surname,
                    CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.UtcNow),
                };
                var identityResult = await _userManager.CreateAsync(user);

                isExternalRegistration = identityResult.Succeeded;
            }
        }

        if (isExternalRegistration)
        {
            await _userManager.AddLoginAsync(user, info);
            var createUserDto = _mapper.Map<UserDTO>(user);
            TokenDTO token = _tokenHandler.GenerateToken(createUserDto);
            await _userService.UpdateRefreshTokenAsync(token.RefreshToken, user, token.AccessTokenExpiry, 15);
            return token;
        }
        throw new Exception("Invalid registration.");
    }




    public Task<TokenDTO> FacebookLoginAsync(string authToken, int accessTokenLifeTime)
    {
        throw new NotImplementedException();
    }

    public Task ForgotPasswordAsync(string usernameOrEmail)
    {
        throw new NotImplementedException();
    }

    public async Task<TokenDTO> GoogleLoginAsync(string idToken, int accessTokenLifeTime)
    {
        throw new NotImplementedException();
    }

    public async Task<TokenDTO> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime)
    {
        Domain.Entities.Identity.AppUser user = await _userManager.FindByNameAsync(usernameOrEmail);

        if (user == null)
            user = await _userManager.FindByEmailAsync(usernameOrEmail);

        if (user == null)
            throw new NotFoundException(ExceptionMessages.UserNotFoundException);

        SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, password, false);
        var createUserDto = _mapper.Map<UserDTO>(user);
        TokenDTO token = _tokenHandler.GenerateToken(createUserDto);

        user.RefreshToken = token.RefreshToken;
        user.RefreshTokenEndDate = token.RefreshTokenExpiry;

        if (result.Succeeded) //Authentication başarılı!
        {
            await _userService.UpdateRefreshTokenAsync(token.RefreshToken, user, token.AccessTokenExpiry, 15);
        }

        return token;
    }

    public async Task<bool> AuthorizeAsync(string username, string permissionCode)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user == null)
        {
            return false;
        }
        return true;
    }



    public async Task PasswordResetAsnyc(string usernameOrEmail)
    {
        var user = await _userManager.FindByNameAsync(usernameOrEmail)
                    ?? await _userManager.FindByEmailAsync(usernameOrEmail);

        if (user == null)
            throw new InvalidOperationException($"User not found with username or email '{usernameOrEmail}'.");

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
    }

    public async Task<TokenDTO> RefreshTokenLoginAsync(string refreshToken)
    {
        AppUser? user = await _userManager.Users.FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);
        if (user != null && user?.RefreshTokenEndDate > DateTime.UtcNow)
        {
            var createUserDto = _mapper.Map<UserDTO>(user);
            TokenDTO token = _tokenHandler.GenerateToken(createUserDto);
            await _userService.UpdateRefreshTokenAsync(token.RefreshToken, user, token.AccessTokenExpiry, 300);
            return token;
        }
        else
            throw new NotFoundException();
    }

    public async Task<CreateUserResponseDTO> CreateUserAsync(CreateUserDTO createUser)
    {
        var commandResponse = new CreateUserResponseDTO();
        return commandResponse;
    }

    public async Task ResetPasswordAsync(string usernameOrEmail, string resetToken, string newPassword)
    {
        // Find the user by username or email
        var user = await _userManager.FindByNameAsync(usernameOrEmail)
                   ?? await _userManager.FindByEmailAsync(usernameOrEmail);

        if (user == null)
        {
            throw new InvalidOperationException($"User not found with username or email '{usernameOrEmail}'.");
        }

        // Reset the user's password using the reset token
        var result = await _userManager.ResetPasswordAsync(user, resetToken, newPassword);
        if (!result.Succeeded)
        {
            throw new InvalidOperationException($"Failed to reset password for user '{usernameOrEmail}'.");
        }
    }

    public async Task<SignInResult> SignInAsync(string username, string password, bool isPersistent, bool lockoutOnFailure)
    {
        var result = await _signInManager.PasswordSignInAsync(username, password, isPersistent, lockoutOnFailure);
        return result;
    }

    public async Task SignOutAsync()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task<bool> VerifyResetTokenAsync(string resetToken, string userId)
    {
        // Kullanıcıyı ID'sine göre bul
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            // Kullanıcı bulunamazsa false döndür
            return false;
        }

        // Verilen tokenın doğruluğunu ve bu tokenın kullanıcıya ait olup olmadığını doğrula
        var result = await _userManager.VerifyUserTokenAsync(user, _userManager.Options.Tokens.PasswordResetTokenProvider, "ResetPassword", resetToken);
        return result;
    }


    public async Task<bool> CheckUserExistence(string userName, string email)
    {
        var userByName = await _userManager.FindByNameAsync(userName);

        var userByEmail = await _userManager.FindByEmailAsync(email);

        if (userByName != null || userByEmail != null)
            return true;
        return false;
    }

    // 3 tanesi için yazalım IAuthenticatorService sınıfı olucak.
    // 
    public async Task<AuthenticationResult> TwoFactorLoginAsync(Guid userId, string twoFactorCode)
    {
        throw new NotImplementedException();
    }

    public async Task<List<string>> GenerateRecoveryCodesAsync()
    {
        throw new NotImplementedException();
        //return await _recoveryCodeService.GenerateRecoveryCodesAsync();
    }

    public async Task<bool> ValidateRecoveryCodeAsync(Guid userId, string recoveryCode)
    {
        throw new NotImplementedException();

        // return await _recoveryCodeService.ValidateRecoveryCodeAsync(userId, recoveryCode);
    }
}

