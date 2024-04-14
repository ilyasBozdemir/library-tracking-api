using System.Reflection;
using System.Text.Json;
using HealthChecks.UI.Client;
using LibraryTrackingApp.Application;
using LibraryTrackingApp.Application.Authorization.Policies;
using LibraryTrackingApp.Application.Filters;
using LibraryTrackingApp.Infrastructure;
using LibraryTrackingApp.Infrastructure.Enums;
using LibraryTrackingApp.Infrastructure.Extensions;
using LibraryTrackingApp.Infrastructure.Helpers;
using LibraryTrackingApp.Persistence;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
    options.Filters.Add<CustomExceptionFilter>();
    options.Filters.Add(new ProducesAttribute("application/json", "application/vnd.api+json"));
    options.Filters.Add(new ConsumesAttribute("application/json", "application/vnd.api+json"));
});

builder.Services.AddControllers();

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddScoped<CustomResourceFilter>();
builder.Services.AddScoped<CustomResultFilter>();
builder.Services.AddScoped<CustomAuthorizationFilter>();

AssemblyHelper.RegisterLayerAssembly(LayerName.WebAPI, Assembly.GetExecutingAssembly()); //WebAPI için assembly bilgisini almak ve altyapıya göndermek için

builder
    .Services.AddHealthChecks()
    .AddProcessAllocatedMemoryHealthCheck(
        maximumMegabytesAllocated: 100,
        tags: new[] { "process", "memory" }
    )
    .AddSqlServer(
        AppConstant.DefaultConnectionString,
        healthQuery: "SELECT 1",
        name: "MS SQL Server Check",
        failureStatus: HealthStatus.Unhealthy | HealthStatus.Degraded,
        tags: new string[] { "db", "sql", "sqlserver" }
    )
    .AddSeqPublisher(
        options =>
        {
            options.ApiKey = "mLfwqzMFjclmP3osKY7d";
            options.Endpoint = "http://localhost:5341";
            options.DefaultInputLevel = HealthChecks.Publisher.Seq.SeqInputLevel.Information;
        },
        "MS SQL Server"
    );

;

builder
    .Services.AddHealthChecksUI(settings =>
    {
        settings.AddHealthCheckEndpoint("MS SQL Server", "/health");
    })
    .AddSqlServerStorage(connectionString: AppConstant.DefaultConnectionString);

#region Katmanların servis kayıtları

builder.Services.AddApplicationRegistration();
builder.Services.AddPersistenceRegistration();
builder.Services.AddInfrastructureServices();

#endregion


var app = builder.Build();
app.UseRouting();
CorsPolicies.UseCustomCorsPolicies(app);
app.UseCustomSwaggerUI(app.Environment, LayerName.WebAPI);

//app.UseVersionValidation();

app.UseHttpsRedirection();



app.UseAuthorization();
app.MapControllers();

app.UseHealthChecks(
    "/health",
    new HealthCheckOptions
    {
        Predicate = _ => true,
        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
    }
);

app.UseRouting()
    .UseEndpoints(config =>
    {
        config.MapHealthChecks(
            "/health-random",
            new HealthCheckOptions
            {
                Predicate = r => r.Tags.Contains("random"),
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            }
        );

        config.MapHealthChecks(
            "/health-process",
            new HealthCheckOptions
            {
                Predicate = r => r.Tags.Contains("process"),
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            }
        );

        config.MapHealthChecksUI();

        config.MapDefaultControllerRoute();
    });



//ui için
app.UseHealthChecksUI(options =>
{
    options.UIPath = "/health-ui";
    options.AsideMenuOpened = true;
});

app.Run();
