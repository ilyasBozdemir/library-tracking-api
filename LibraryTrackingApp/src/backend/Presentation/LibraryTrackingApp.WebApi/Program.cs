using LibraryTrackingApp.Infrastructure;
using LibraryTrackingApp.Application;
using LibraryTrackingApp.Persistence;
using LibraryTrackingApp.Application.Filters;
using LibraryTrackingApp.Infrastructure.Enums;
using LibraryTrackingApp.Infrastructure.Helpers;
using System.Reflection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using System.Text.Json;
using HealthChecks.UI.Core;



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


AssemblyHelper.RegisterLayerAssembly(LayerName.WebAPI, Assembly.GetExecutingAssembly());//WebAPI için assembly bilgisini almak ve altyapıya göndermek için

builder.Services.AddHealthChecks()
    .AddSqlServer(AppConstant.DefaultConnectionString,
    healthQuery: "SELECT 1",
    name: "MS SQL Server Check",
    failureStatus: HealthStatus.Unhealthy | HealthStatus.Degraded,
    tags: new string[] { "db", "sql", "sqlserver" }
    )
   .AddSeqPublisher(options =>
   {
       options.ApiKey = "mLfwqzMFjclmP3osKY7d";
       options.Endpoint = "http://localhost:5341";
       options.DefaultInputLevel = HealthChecks.Publisher.Seq.SeqInputLevel.Information;
   }, "Service 1");

;


builder.Services
    .AddHealthChecksUI(settings =>
    {
        settings.AddHealthCheckEndpoint("MS SQL Server", "https://localhost:7115/health");
    })
    .AddSqlServerStorage(connectionString: AppConstant.DefaultConnectionString);
    


#region Katmanların servis kayıtları

builder.Services.AddApplicationRegistration();
builder.Services.AddPersistenceRegistration();
builder.Services.AddInfrastructureServices();

#endregion


var app = builder.Build();

app.UseCustomSwaggerUI(app.Environment, LayerName.WebAPI);

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();


app.UseHealthChecks("/health", new HealthCheckOptions
{
    //Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});


app.UseHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = async (context, report) =>
    {
        context.Response.ContentType = "application/json";

        var result = JsonSerializer.Serialize(
            new
            {
                status = report.Status.ToString(),
                checks = report.Entries.Select(e => new
                {
                    name = e.Key,
                    status = e.Value.Status.ToString(),
                    exception = e.Value.Exception?.Message,
                    duration = e.Value.Duration
                })
            });

        await context.Response.WriteAsync(result);
    }
});



//ui için
app.UseHealthChecksUI(options =>
{
    options.UIPath = "/health-ui";
});


app.Run();