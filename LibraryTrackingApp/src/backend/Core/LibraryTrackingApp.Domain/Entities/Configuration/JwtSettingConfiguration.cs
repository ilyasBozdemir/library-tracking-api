
namespace LibraryTrackingApp.Domain.Entities.Configuration;

public class JwtSettingConfiguration : BaseEntity<int>
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }//aes ile şifrelenecek ilerde.
    public int AccessTokenExpirationMinutes { get; set; }
    public bool Enabled { get; set; }
}
