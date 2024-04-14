using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class BasePathDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        swaggerDoc.Servers = new List<OpenApiServer>()
    {
            //launchSettings.json içinden alınmıştır
            new OpenApiServer { Url = "https://localhost:7115" }, 
            new OpenApiServer { Url = "http://localhost:5256" },
    };
    }
}
