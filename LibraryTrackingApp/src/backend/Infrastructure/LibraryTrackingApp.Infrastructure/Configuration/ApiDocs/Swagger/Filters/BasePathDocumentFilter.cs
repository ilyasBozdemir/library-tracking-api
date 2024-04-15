using LibraryTrackingApp.Domain.Constants;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class BasePathDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        swaggerDoc.Servers = new List<OpenApiServer>()
    {
            new OpenApiServer { Url = AppConstant.openApiServer }, 
            new OpenApiServer { Url = AppConstant.openApiServer2 },
    };
    }
}