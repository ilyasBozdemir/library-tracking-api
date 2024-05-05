namespace LibraryTrackingApp.Domain.Entities.Configuration;

public class MailAccountConfiguration : BaseEntity<int>
{
    public int Id { get; set; }

    public string Purpose { get; set; }
    public string SmtpServer { get; set; }
    public int Port { get; set; }

    public string SenderEmail { get; set; }
    public string SenderName { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }
}

