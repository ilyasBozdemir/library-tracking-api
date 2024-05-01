using LibraryTrackingApp.Application.Authorization.Policies;
using LibraryTrackingApp.Application.Behaviors;
using LibraryTrackingApp.Application.Features.AppUsers.Behaviors.Mapping;
using LibraryTrackingApp.Application.Features.Authors.Behaviors.Mapping;
using LibraryTrackingApp.Application.Features.BookStocks.Behaviors.Mapping;
using LibraryTrackingApp.Application.Features.BorrowLend.Behaviors.Mapping;
using LibraryTrackingApp.Application.Features.WorkInventories.Behaviors.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LibraryTrackingApp.Application;

public static class ServiceRegistration
{
    public static void AddApplicationRegistration(this IServiceCollection services)
    {
        services.AddMemoryCache();
        CorsPolicies.AddCorsPolicies(services);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        //services.AddAutoMapper(Assembly.GetExecutingAssembly());


        MapperConfiguration mapperConfiguration = new MapperConfiguration(mapperConfig => {
            mapperConfig.AddProfile<UserMappingsProfile>();
            mapperConfig.AddProfile<AuthorMappingProfile>();
            mapperConfig.AddProfile<BookMappingProfile>();
            mapperConfig.AddProfile<BookStockMappingProfile>();
            mapperConfig.AddProfile<BorrowLendMappingProfile>();
           
            //BorrowLendMappingProfile
        });

        services.AddSingleton(mapperConfiguration.CreateMapper());




        // LibraryTrackingApp.Application.Behaviors içindekileri buraya kaydet.

        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ExceptionHandlingBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
       
    }
}
