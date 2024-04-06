namespace LibraryTrackingApp.Domain.Exceptions;

public class CustomGeneralException : Exception
{
    public int ErrorCode { get; }


    public CustomGeneralException(string message) : base(message)
    {
    }

    public CustomGeneralException(string message, int errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }

    public CustomGeneralException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public CustomGeneralException(string message, int errorCode, Exception innerException) : base(message, innerException)
    {
        ErrorCode = errorCode;
    }
}
