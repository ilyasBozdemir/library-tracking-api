using LibraryTrackingApp.Infrastructure;
using LibraryTrackingApp.Application;
using LibraryTrackingApp.Persistence;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

#region Katmanlar�n servis kay�tlar�

builder.Services.AddApplicationRegistration();
builder.Services.AddPersistenceRegistration(configuration);
builder.Services.AddInfrastructureServices();

#endregion


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();