using LibraryTrackingApp.Infrastructure;
using LibraryTrackingApp.Application;
using LibraryTrackingApp.Persistence;
using LibraryTrackingApp.Application.Filters;
using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Helpers;
using LibraryTrackingApp.Infrastructure.Enums;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
    options.Filters.Add<CustomExceptionFilter>();
    options.Filters.Add(new ProducesAttribute("application/json", "application/vnd.api+json"));
    options.Filters.Add(new ConsumesAttribute("application/json", "application/vnd.api+json"));

});


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

builder.Services.AddScoped<CustomResourceFilter>();
builder.Services.AddScoped<CustomResultFilter>();
builder.Services.AddScoped<CustomAuthorizationFilter>();

#region Katmanlarýn servis kayýtlarý

builder.Services.AddApplicationRegistration();
builder.Services.AddPersistenceRegistration();
builder.Services.AddInfrastructureServices();

#endregion


var app = builder.Build();

app.UseCustomSwaggerUI(app.Environment, LayerName.WebAPI);

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();