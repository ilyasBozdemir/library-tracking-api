using LibraryTrackingApp.Application.Features.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LibraryTrackingApp.Application;

public static class ServiceRegistration
{
    public static void AddApplicationRegistration(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        //services.AddAutoMapper(Assembly.GetExecutingAssembly());


        // LibraryTrackingApp.Application.Behaviors içindekileri buraya kaydet.

        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ExceptionHandlingBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
       
    }
}
