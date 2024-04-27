namespace LibraryTrackingApp.Application.DataTransferObjects;

public record ListMailConfigurationDTO : BaseAuditableDTO<int>
{
    public int Id { get; set; }
    public string Owner { get; set; }
    public string SmtpServer { get; set; }
    public int Port { get; set; }
    public string SenderEmail { get; set; }
    public string SenderName { get; set; }
    public string Username { get; set; }
}
