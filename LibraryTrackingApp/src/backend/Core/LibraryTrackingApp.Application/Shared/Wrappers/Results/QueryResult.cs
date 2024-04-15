namespace LibraryTrackingApp.Application.Shared.Wrappers.Results;

public class QueryResult : ActionResult
{
    public object Data { get; set; }
    public QueryResult(bool success, int statusCode, string[] stateMessages = null)
        : base(success, statusCode, stateMessages)
    {
    }
    public QueryResult(bool success, int statusCode, object data, string[] stateMessages = null)
      : base(success, statusCode, stateMessages)
    {
        Data = data;
    }
    public QueryResult() { }
}


public class QueryResult<T> : ActionResult
{
    public T Data { get; set; }

    public QueryResult(bool success, int statusCode, string[] stateMessages = null)
        : base(success, statusCode, stateMessages)
    {
    }
    public QueryResult(bool success, int statusCode, T data, string[] stateMessages = null)
        : base(success, statusCode, stateMessages)
    {
        Data = data;
    }
    public QueryResult() { }
}
