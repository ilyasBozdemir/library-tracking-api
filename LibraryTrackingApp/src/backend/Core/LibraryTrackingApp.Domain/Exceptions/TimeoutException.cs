namespace LibraryTrackingApp.Domain.Exceptions;

public class TimeoutException : Exception
{
    public TimeoutException(string? message) : base(message)
    {
    }

    public TimeoutException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
