

namespace LibraryTrackingApp.Application.Features.Behaviors;

public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        // İstek öncesi loglama
        Console.WriteLine($"Handling {typeof(TRequest).Name}");

        var response = await next();

        // Yanıt sonrası loglama
        Console.WriteLine($"Handled {typeof(TRequest).Name}");

        return await next();
    }
}

