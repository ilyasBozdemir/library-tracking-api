using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;


public class ResponseOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        // 200 - OK
        AddResponse(operation, "200", "İşlem başarılı oldu.");

        //201 - Created.
        AddResponse(operation, "201", "Kaynak başarıyla oluşturuldu.");


        // 400 - Bad Request
        AddResponse(operation, "400", "Geçersiz istek.");

        // 404 - Not Found
        AddResponse(operation, "404", "Kaynak bulunamadı.");

        // 409 - Conflict
        AddResponse(operation, "409", "Bu bilgilere sahip bir data zaten mevcut.");


        // 500 - Internal Server Error
        AddResponse(operation, "500", "Sunucu hatası.");
    }

    private void AddResponse(OpenApiOperation operation, string statusCode, string description)
    {
        if (operation.Responses.TryGetValue(statusCode, out OpenApiResponse response))
        {
            response.Description = description;
            response.Links = new Dictionary<string, OpenApiLink>
            {
                { "documentation", new OpenApiLink { Description = "Dokümantasyon için", OperationId = "ErrorCode" + statusCode } }
            };
        }
    }
}


