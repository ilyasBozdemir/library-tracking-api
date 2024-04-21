namespace LibraryTrackingApp.Application.Shared.Wrappers.Results;
public abstract class ActionResult
{
    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public object? Data { get; set; }
    public string[] StateMessages { get; set; }

    public ActionResult(
        bool success,
        int statusCode,
        string[] stateMessages = null,
        object? data = null
    )
    {
        Success = success;
        StatusCode = statusCode;
        StateMessages = stateMessages ?? Array.Empty<string>();
        Data = data;
    }

    public ActionResult()
    {
        Success = true;
        StatusCode = 200;
        StateMessages = Array.Empty<string>();
        Data = null;
    }
}