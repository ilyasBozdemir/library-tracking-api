using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs;
using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger;
using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Filters;
using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger.Security;
using LibraryTrackingApp.Infrastructure.Enums;
using LibraryTrackingApp.Infrastructure.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace LibraryTrackingApp.Infrastructure.Helpers;
/// <summary>
/// Yardımcı sınıf, Swagger yapılandırma ve kullanıcı arayüzü oluşturma işlemlerini sağlar.
/// </summary>
public static class SwaggerHelper
{
    private static IDictionary<string, OpenApiInfo>? apiInfos;


    /// <summary>
    /// Servisleri Swagger ile yapılandırır.
    /// </summary>
    /// <param name="services">IServiceCollection örneği.</param>
    /// <param name="layerName">Swagger'ın yapılandırılacağı katmanın adı.</param>
    public static void ConfigureSwagger(this IServiceCollection services, LayerName layerName)
    {
        apiInfos = GetApiInfos(layerName);
        services.AddEndpointsApiExplorer();

        IOrderedEnumerable<ApiVersion> apiVersions = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(CustomBaseController).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
            .SelectMany(t => t.GetCustomAttributes<ApiVersionAttribute>(true))
            .SelectMany(a => a.Versions)
            .Distinct()
            .OrderBy(v => v.ToString());


        Assembly assembly = AssemblyHelper.GetLayerAssembly(layerName);

        services.AddSwaggerGen(c =>
        {
            c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

            foreach (var version in apiVersions)
            {
                var versionStr = $"v{version}";



                if (apiInfos.TryGetValue(versionStr, out var openApiInfo))
                {

                    c.SwaggerDoc(versionStr, openApiInfo);


                    var xmlFile = $"{assembly.GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    Console.WriteLine(xmlPath);
                    c.IncludeXmlComments(xmlPath);

                }
                else { }
            }

            c.DocInclusionPredicate(
                (docName, apiDesc) =>
                {
                    if (!apiDesc.TryGetMethodInfo(out MethodInfo methodInfo))
                    {
                        return false;
                    }

                    var versions = methodInfo
                        .DeclaringType?.GetCustomAttributes(true)
                        .OfType<ApiVersionAttribute>()
                        .SelectMany(attr => attr.Versions)
                        .Select(v => $"v{v}");

                    return versions.Any(v => v == docName);
                }
            );

            if (!c.OperationFilterDescriptors.Any(x => x.Type == typeof(SecurityOperationFilter)))
            {
                c.AddSecurityRequirement(OpenApiSecurityRequirements.BearerSecurityRequirement);
                c.AddSecurityDefinition("Bearer", SecuritySchemes.BearerSecurityScheme);
                c.OperationFilter<ParameterOperationFilter>();
                c.OperationFilter<ResponseOperationFilter>();
                c.OperationFilter<SecurityOperationFilter>();
                //c.OperationFilter<DocumentationOperationFilter>();
                c.OperationFilter<CustomMetadataOperationFilter>();
                c.OperationFilter<HeaderParameter>();
                c.OperationFilter<AuthorizationHeaderOperationFilter>();


            }
        });

        services.AddApiVersioning(setup =>
        {
            setup.DefaultApiVersion = new ApiVersion(1, 0);
            setup.AssumeDefaultVersionWhenUnspecified = true;
            setup.ReportApiVersions = true;
            setup.ReportApiVersions = true;
        });

        services.AddEndpointsApiExplorer();
    }



    /// <summary>
    /// Özel Swagger kullanıcı arayüzünü uygular.
    /// </summary>
    /// <param name="app">IApplicationBuilder örneği.</param>
    /// <param name="env">IWebHostEnvironment örneği.</param>
    /// <param name="layerName">Kullanıcı arayüzünün uygulanacağı katmanın adı.</param>
    public static void UseCustomSwaggerUI(
        this IApplicationBuilder app,
        IWebHostEnvironment env,
        LayerName layerName
    )
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            foreach (var apiVersionInfo in GetAllVersions(layerName))
            {
                c.SwaggerEndpoint(
                    $"/swagger/{apiVersionInfo.Version}/swagger.json",
                    $"{apiVersionInfo.OpenApiInfo.Title}"
                );
            }
        });
    }


    /// <summary>
    /// Belirtilen katmandaki tüm API versiyon bilgilerini alır.
    /// </summary>
    /// <param name="layerName">API versiyon bilgilerinin alınacağı katmanın adı.</param>
    /// <returns>API versiyon bilgilerinin koleksiyonu.</returns>
    private static IEnumerable<ApiVersionInfo> GetAllVersions(LayerName layerName)
    {
        switch (layerName)
        {
            case LayerName.WebAPI:
                return WebApiVersionInfos.GetAllVersions();

            default:
                throw new ArgumentException("Invalid layer name");
        }
    }


    /// <summary>
    /// Belirtilen katmandaki tüm API OpenAPI bilgilerini alır.
    /// </summary>
    /// <param name="layerName">API OpenAPI bilgilerinin alınacağı katmanın adı.</param>
    /// <returns>API OpenAPI bilgilerinin sözlüğü.</returns>
    private static IDictionary<string, OpenApiInfo> GetApiInfos(LayerName layerName)
    {
        // Belirli katman adına göre API OpenAPI bilgilerini döndür
        switch (layerName)
        {
            case LayerName.WebAPI:
                return WebApiVersionInfos
                    .GetAllVersions()
                    .ToDictionary(v => v.Version, v => v.OpenApiInfo);


            default:
                throw new ArgumentException("Invalid layer name");
        }
    }
}