namespace LibraryTrackingApp.Domain.Exceptions;

public class AuthenticationErrorException : Exception
{

    public AuthenticationErrorException(string? message) : base(message)
    {
    }

    public AuthenticationErrorException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
