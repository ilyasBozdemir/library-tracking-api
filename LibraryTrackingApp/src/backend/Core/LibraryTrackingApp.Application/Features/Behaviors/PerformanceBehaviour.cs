using System.Diagnostics;

namespace LibraryTrackingApp.Application.Features.Behaviors;

public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    // Performans izleme ve loglama
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var stopwatch = Stopwatch.StartNew();
        var response = await next();
        stopwatch.Stop();

        if (stopwatch.ElapsedMilliseconds > 500) // Örnek olarak 500 ms
        {
            var requestName = typeof(TRequest).Name;
            Console.WriteLine($"Long Running Request: {requestName} ({stopwatch.ElapsedMilliseconds} milliseconds)");
        }

        return await next();
    }
}
