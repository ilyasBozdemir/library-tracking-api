using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class ResponseOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        /*
             foreach (var response in operation.Responses)
             {
                 // Örnek olarak, 200 HTTP durum koduna özel bir açıklama ekme
                 if (response.Key == "200")
                 {
                     response.Value.Description = "İşlem başarılı oldu.";
                 }
             }*/
    }
}
