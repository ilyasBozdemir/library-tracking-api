namespace LibraryTrackingApp.Domain.Exceptions;

public class CreateFailedException : Exception
{

    public CreateFailedException(string? message) : base(message)
    {
    }

    public CreateFailedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
