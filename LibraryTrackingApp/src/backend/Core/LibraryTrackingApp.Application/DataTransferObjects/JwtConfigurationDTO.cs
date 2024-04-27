namespace LibraryTrackingApp.Application.DataTransferObjects;
public record JwtConfigurationDTO : BaseAuditableDTO<int>
{
    public string Subject { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }
    public int AccessTokenExpirationMinutes { get; set; }
}
