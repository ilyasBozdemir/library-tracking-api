namespace LibraryTrackingApp.Domain.Exceptions;

public class EmptyException : Exception
{
    public EmptyException(string? message) : base(message)
    {
    }

    public EmptyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
