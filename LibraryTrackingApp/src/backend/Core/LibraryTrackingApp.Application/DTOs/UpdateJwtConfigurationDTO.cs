namespace LibraryTrackingApp.Application.DTOs;

public record UpdateJwtConfigurationDTO : BaseAuditableDTO<Guid>
{
    public Guid Id { get; set; }
    public string Subject { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }
    public int AccessTokenExpirationMinutes { get; set; }
}

