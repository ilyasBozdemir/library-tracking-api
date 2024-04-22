namespace LibraryTrackingApp.Application.DTOs;

public record ListJwtConfigurationDTO : BaseAuditableDTO<int>
{
    public List<JwtConfigurationDTO> JwtSettings { get; set; }
}
