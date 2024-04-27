using LibraryTrackingApp.Application.DataTransferObjects;

namespace LibraryTrackingApp.Application.Interfaces.Services.Messaging;

public interface IMailService
{
    Task SendMailAsync(MailMessageDTO message);
}

