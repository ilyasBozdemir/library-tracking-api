using FluentValidation;
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
    }
}
