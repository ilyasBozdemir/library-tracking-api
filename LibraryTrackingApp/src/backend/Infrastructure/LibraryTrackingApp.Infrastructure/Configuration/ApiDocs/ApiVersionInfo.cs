using Microsoft.OpenApi.Models;


namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs;

public class ApiVersionInfo
{
    public string Version { get; set; }
    public OpenApiInfo OpenApiInfo { get; set; }
}