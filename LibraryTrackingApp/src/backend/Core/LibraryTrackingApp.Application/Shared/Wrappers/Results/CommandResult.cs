namespace LibraryTrackingApp.Application.Shared.Wrappers.Results;

public class CommandResult : ActionResult
{
    public CommandResult(bool success, int statusCode, string[] stateMessages = null)
        : base(success, statusCode, stateMessages)
    {
    }
    public CommandResult()
    {

    }
}
public class CommandResult<T> : CommandResult
{
    public T Data { get; set; }

    public CommandResult(bool success, int statusCode, T data, string[] stateMessages = null)
        : base(success, statusCode, stateMessages)
    {
        Data = data;
    }
}
