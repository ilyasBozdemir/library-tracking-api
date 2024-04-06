namespace LibraryTrackingApp.Domain.Exceptions;

public class LockoutAccountException : Exception
{
    public LockoutAccountException(string message) : base(message)
    {
    }
}

