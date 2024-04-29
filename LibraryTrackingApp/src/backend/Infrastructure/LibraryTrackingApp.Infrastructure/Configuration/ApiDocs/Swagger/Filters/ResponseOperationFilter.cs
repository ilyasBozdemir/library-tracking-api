using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;

public class ResponseOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        var responseTypes = new List<(int, string, object)>
        {
            (
                200,
                "Başarılı bir cevap durumu",
                new
                {
                    IsSuccess = true,
                    StatusCode = 200,
                    Messages = new string[] { },
                    Data = new { }
                }
            ),
            (
                400,
                "Geçersiz istek durumu",
                new
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Messages = new string[] { "Geçersiz istek" },
                    Data = new { }
                }
            ),
            (
                401,
                "Yetkilendirme başarısız durumu",
                new
                {
                    IsSuccess = false,
                    StatusCode = 401,
                    Messages = new string[] { "Yetkilendirme başarısız" },
                    Data = new { }
                }
            ),
            (
                403,
                "Yetkilendirme reddi durumu",
                new
                {
                    IsSuccess = false,
                    StatusCode = 403,
                    Messages = new string[] { "Yetkilendirme reddi" },
                    Data = new { }
                }
            ),
            (
                404,
                "Kaynak bulunamadı durumu",
                new
                {
                    IsSuccess = false,
                    StatusCode = 404,
                    Messages = new string[] { "Kaynak bulunamadı" },
                    Data = new { }
                }
            ),
            (
                405,
                "İzin verilmeyen yöntem durumu",
                new
                {
                    IsSuccess = false,
                    StatusCode = 405,
                    Messages = new string[] { "İzin verilmeyen yöntem" },
                    Data = new { }
                }
            ),
            (
                409,
                "Çakışma durumu (Conflict)",
                new
                {
                    IsSuccess = false,
                    StatusCode = 409,
                    Messages = new string[] { "Çakışma" },
                    Data = new { }
                }
            ),
            (
                500,
                "Sunucu hatası durumu",
                new
                {
                    IsSuccess = false,
                    StatusCode = 500,
                    Messages = new string[] { "Sunucu hatası" },
                    Data = new { }
                }
            )
        };

        foreach (var (statusCode, description, exampleData) in responseTypes)
        {
            operation.Responses[statusCode.ToString()] = new OpenApiResponse
            {
                Description = description,
                Content = new Dictionary<string, OpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType
                    {
                        Schema = new OpenApiSchema
                        {
                            Type = "object", // JSON nesnesi
                            Properties = new Dictionary<string, OpenApiSchema>
                            {
                                ["IsSuccess"] = new OpenApiSchema { Type = "boolean" },
                                ["StatusCode"] = new OpenApiSchema { Type = "integer" },
                                ["Messages"] = new OpenApiSchema
                                {
                                    Type = "array",
                                    Items = new OpenApiSchema { Type = "string" }
                                },
                                ["Data"] = new OpenApiSchema
                                {
                                    Type = "object",
                                    Example = new OpenApiString(
                                        JsonConvert.SerializeObject(exampleData)
                                    )
                                } // Örnek veri burada sağlanır
                            },
                            Description = description
                        }
                    }
                }
            };
        }
    }
}
