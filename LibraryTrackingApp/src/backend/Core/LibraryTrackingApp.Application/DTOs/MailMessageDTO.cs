namespace LibraryTrackingApp.Application.DTOs;

public class MailMessageDTO
{
    public string From { get; set; }
    public string FromName { get; set; }
    public List<string> To { get; set; }
    public List<string>? Cc { get; set; }
    public List<string>? Bcc { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public bool IsBodyHtml { get; set; }
    public string Password { get; set; }

    public List<AttachmentDTO>? Attachments { get; set; }
}
