using AutoMapper;
using LibraryTrackingApp.Application.Interfaces.Services;
using LibraryTrackingApp.Domain.Exceptions;
using PreAccountingBE.Application.Features.DTOs.User;
using System.Security.Claims;

namespace LibraryTrackingApp.Persistence.Services;


public class UserService : IUserService
{
    private readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;
    private readonly RoleManager<Domain.Entities.Identity.AppRole> _roleManager;

    private readonly IMapper _mapper;


    public UserService(
        UserManager<AppUser> userManager,
        IMapper mapper
        )
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public int TotalUsersCount => _userManager.Users.Count();

    public async Task AddRolesToUserAsync(Guid userId, string[] roles)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with ID '{userId}'.");
        }

        foreach (var roleName in roles)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                throw new InvalidOperationException($"Role '{roleName}' does not exist.");
            }
        }

        var result = await _userManager.AddToRolesAsync(user, roles);
        if (!result.Succeeded)
        {
            throw new InvalidOperationException($"Failed to add roles to user with ID '{userId}'.");
        }
    }

    public async Task AssignRoleToUserAsnyc(Guid userId, string[] roles)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with ID '{userId}'.");
        }

        foreach (var roleName in roles)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                throw new InvalidOperationException($"Role '{roleName}' does not exist.");
            }

            var result = await _userManager.AddToRoleAsync(user, roleName);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Failed to assign role '{roleName}' to user with ID '{userId}'.");
            }
        }
    }

    public async Task<CreateUserResponseDTO> CreateAsync(CreateUserDTO model)
    {
        IdentityResult result = await _userManager.CreateAsync(new()
        {
            Id = Guid.NewGuid(),
            UserName = model.UserName,
            Email = model.Email,
            Name = model.Name,
            Surname = model.Surname,
            CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            CreatedById = model.Id,
            LastModifiedById = model.Id,
            LastModifiedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),

        }, model.Password);

        CreateUserResponseDTO response = new() { Succeeded = result.Succeeded };

        if (result.Succeeded)
            response.Message = "Kullanıcı başarıyla oluşturulmuştur.";
        else
            foreach (var error in result.Errors)
                response.Message += $"{error.Code} - {error.Description}\n";

        return response;
    }

    public async Task<List<ListUserDto>> GetAllUsersAsync(int page, int size)
    {
        var users = _userManager.Users.Skip((page - 1) * size).Take(size);
        var dtos = new List<ListUserDto>();

        foreach (var user in users)
        {
            var dto = new ListUserDto
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                TwoFactorEnabled = user.TwoFactorEnabled
                //
            };

            dtos.Add(dto);
        }

        return dtos;
    }

    public async Task<string[]> GetRolesForUserAsync(Guid userId)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with ID '{userId}'.");
        }

        var roles = await _userManager.GetRolesAsync(user);
        return roles.ToArray();
    }

    public async Task<string[]> GetRolesToUserAsync(Guid userId)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with ID '{userId}'.");
        }

        var roles = await _userManager.GetRolesAsync(user);
        return roles.ToArray();
    }

    public async Task<string[]> GetRolesToUserAsync(string username)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with username '{username}'.");
        }

        var roles = await _userManager.GetRolesAsync(user);
        return roles.ToArray();
    }

    public async Task<string[]> GetRolesToUserAsync(Guid userId, string username)
    {
        AppUser user = null;

        if (userId != Guid.Empty)
        {
            user = await _userManager.FindByIdAsync(userId.ToString());
        }
        else if (!string.IsNullOrEmpty(username))
        {
            user = await _userManager.FindByNameAsync(username);
        }
        else
        {
            throw new ArgumentException("UserId or username must be provided.");
        }

        if (user == null)
        {
            throw new InvalidOperationException($"User not found.");
        }

        var roles = await _userManager.GetRolesAsync(user);
        return roles.ToArray();
    }

    public async Task<string[]> GetPermissionsForUserAsync(Guid userId)
    {
        var permissions = new List<string>();
        return permissions.ToArray();
    }


    public async Task<AppUser> GetUserById(Guid userId)
    {
        var userEntity = await _userManager.FindByIdAsync(userId.ToString());

        // Eğer kullanıcı varsa, entity'i UserDto'ya dönüştür ve döndür
        if (userEntity != null)
        {
            return userEntity;
        }

        // Eğer kullanıcı bulunamazsa, null dönebilir veya bir hata işleme stratejisi uygulanabilir.
        return null;
    }

    public async Task<AppUser> GetUserByEmailAsync(string email)
    {
        return await _userManager.FindByEmailAsync(email);
    }


    public async Task<bool> HasPermissionAsync(Guid userId, string permissionCode)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with ID '{userId}'.");
        }

        var roles = await _userManager.GetRolesAsync(user);

        foreach (var roleName in roles)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role != null && await _roleManager.GetClaimsAsync(role) is IList<Claim> claims)
            {
                if (claims.Any(c => c.Type == "Permission" && c.Value == permissionCode))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public async Task<bool> HasRolePermissionToEndpointAsync(string roleName, string code)
    {
        throw new NotImplementedException();// yazılcaktıor sonrasında
    }


    public async Task RemoveRolesFromUserAsync(Guid userId, string[] roles)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with ID '{userId}'.");
        }

        var result = await _userManager.RemoveFromRolesAsync(user, roles);
        if (!result.Succeeded)
        {
            throw new InvalidOperationException($"Failed to remove roles from user with ID '{userId}'.");
        }
    }

    public async Task UpdatePasswordAsync(Guid userId, string resetToken, string newPassword)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new InvalidOperationException($"User not found with ID '{userId}'.");
        }

        // Verify the reset token before updating the password
        var result = await _userManager.ResetPasswordAsync(user, resetToken, newPassword);
        if (!result.Succeeded)
        {
            throw new InvalidOperationException($"Failed to update password for user with ID '{userId}'.");
        }
    }

    public async Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate)
    {
        if (user != null)
        {
            user.RefreshToken = refreshToken;
            user.RefreshTokenEndDate = accessTokenDate.AddSeconds(addOnAccessTokenDate);
            await _userManager.UpdateAsync(user);
        }
        else
            throw new NotFoundException();
    }
}
