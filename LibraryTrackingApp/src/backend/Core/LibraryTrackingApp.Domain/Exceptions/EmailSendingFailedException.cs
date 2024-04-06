namespace LibraryTrackingApp.Domain.Exceptions;

public class EmailSendingFailedException : Exception
{
    public EmailSendingFailedException(string? message) : base(message)
    {
    }

    public EmailSendingFailedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
