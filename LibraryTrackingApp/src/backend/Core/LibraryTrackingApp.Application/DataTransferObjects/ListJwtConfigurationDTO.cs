namespace LibraryTrackingApp.Application.DataTransferObjects;

public record ListJwtConfigurationDTO : BaseAuditableDTO<int>
{
    public List<JwtConfigurationDTO> JwtSettings { get; set; }
}
