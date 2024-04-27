using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Domain.Entities.Identity;

namespace LibraryTrackingApp.Application.Interfaces.Services;

public interface IUserService
{
    Task<CreateUserResponseDTO> CreateAsync(CreateUserDTO model);
    Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    Task UpdatePasswordAsync(Guid userId, string resetToken, string newPassword);
    Task<List<ListUserDto>> GetAllUsersAsync(int page, int size);
    int TotalUsersCount { get; }
    Task AssignRoleToUserAsnyc(Guid userId, string[] roles);
    Task<string[]> GetRolesToUserAsync(Guid userId);
    Task<string[]> GetRolesToUserAsync(string username);
    Task<string[]> GetRolesToUserAsync(Guid userId, string username);
    Task<string[]> GetRolesForUserAsync(Guid userId);
    Task<string[]> GetPermissionsForUserAsync(Guid userId);

    Task<bool> HasRolePermissionToEndpointAsync(string name, string code);

    Task<bool> HasPermissionAsync(Guid userId, string permissionCode);

    Task AddRolesToUserAsync(Guid userId, string[] roles);

    Task RemoveRolesFromUserAsync(Guid userId, string[] roles);


    Task<AppUser> GetUserById(Guid userId);
    Task<AppUser> GetUserByEmailAsync(string email);

}
