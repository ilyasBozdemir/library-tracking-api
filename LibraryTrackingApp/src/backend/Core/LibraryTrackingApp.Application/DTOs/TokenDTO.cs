namespace LibraryTrackingApp.Application.DTOs;

public class TokenDTO
{
    public string AccessToken { get; set; }
    public DateTime AccessTokenExpiry { get; set; }

    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiry { get; set; }
}

/*
 
public class Token
{
    public Guid Id { get; set; }
    public string TokenValue { get; set; }
    public TokenType TokenType { get; set; }
    public DateTime Expiration { get; set; }
}

*/