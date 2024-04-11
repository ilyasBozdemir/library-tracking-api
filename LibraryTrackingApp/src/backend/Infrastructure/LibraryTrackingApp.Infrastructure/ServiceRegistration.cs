using LibraryTrackingApp.Infrastructure.Enums;
using LibraryTrackingApp.Infrastructure.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LibraryTrackingApp.Infrastructure;


public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.ConfigureSwagger(LayerName.WebAPI);
    }
}
