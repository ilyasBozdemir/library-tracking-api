using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Responses;


namespace LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;

public class CreateMailConfigurationCommandRequest : IRequest<CreateMailConfigurationCommandResponse>
{
    public string Owner { get; set; }
    public string SmtpServer { get; set; }
    public int Port { get; set; }
    public string SenderEmail { get; set; }
    public string SenderName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
