using System.Net;

namespace LibraryTrackingApp.WebApi.Middlewares;

public class ExceptionHandler : Microsoft.AspNetCore.Diagnostics.IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {

        var model = new ProblemDetails
        {
            Status = (int)HttpStatusCode.NotFound,
            Type = exception.GetType().Name,
            Title = "An unexpected error occurred",
            Detail = exception.Message,
            Instance = $"{httpContext.Request.Method} {httpContext.Request.Path}"
        };

        httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;

        await httpContext.Response
            .WriteAsJsonAsync(model, cancellationToken);

        return true;
    }
}
