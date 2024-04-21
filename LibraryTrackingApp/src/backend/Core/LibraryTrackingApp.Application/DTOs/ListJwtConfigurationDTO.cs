namespace LibraryTrackingApp.Application.DTOs;

public record ListJwtConfigurationDTO : BaseAuditableDTO<Guid>
{
    public List<JwtConfigurationDTO> JwtSettings { get; set; }
}
