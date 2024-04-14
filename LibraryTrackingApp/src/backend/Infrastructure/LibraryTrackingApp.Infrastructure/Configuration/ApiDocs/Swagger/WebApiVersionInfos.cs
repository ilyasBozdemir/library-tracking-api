using LibraryTrackingApp.Domain.Constants;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger;

public static class WebApiVersionInfos
{
    public static IEnumerable<ApiVersionInfo> GetAllVersions()
    {
        yield return V1;
    }
  

    public static ApiVersionInfo V1 => new ApiVersionInfo
    {
        Version = $"v{ApiVersions.V1}",
        OpenApiInfo = new OpenApiInfo
        {
            Title = $"Kütüphane Takip Uygulaması",
            Version = $"v{ApiVersions.V1}",
            Description =
            """
            ## Giriş
            Bu API v1 sürümü, kütüphane takip uygulaması için kapsamlı bir dizi özellik sunmaktadır:
            - **Kitap ve Kategori Yönetimi**: Kitapların ve kategorilerin kaydedilmesi, düzenlenmesi ve sorgulanması.
            - **Üye Yönetimi**: Kütüphane üyelerinin kaydedilmesi ve takibi
            - **Ödünç Alma ve İade İşlemleri**: Kitap ödünç alma, iade etme ve süre uzatma işlemleri.
            - **Personel Yönetimi**: Kütüphane personelinin yönetimi ve yetkilendirilmesi.
            - **Kütüphane İşlemleri Takibi**: Kütüphane içi işlemlerin detaylı kaydı ve raporlanması.
            - **Yönetim ve Raporlama Araçları**: Kapsamlı yönetim ve raporlama araçları.
            - **Kullanıcı Hesapları ve İzinler**: Çok kullanıcılı hesap yönetimi ve rol bazlı erişim kontrolleri.
            """,
            Contact = new OpenApiContact
            {
                Name = AppConstant.contactName,
                Email = AppConstant.contactEmail
            },
            License = new OpenApiLicense
            {
                Name = "API Lisansı",
                Url = new Uri(string.Format(AppConstant.licenseUrlTemplate, AppConstant.repositoryOwner, AppConstant.repositoryName))
            },
            Extensions = new Dictionary<string, IOpenApiExtension>
            {
                ["x-logo"] = new OpenApiObject
                {
                    ["url"] = new OpenApiString(AppConstant.projectLogoUrl)
                },
                ["bgcolor"] = new OpenApiString(AppConstant.bgColor),

                ["termsOfService"] = new OpenApiString(string.Format(AppConstant.termsUrlTemplate, AppConstant.repositoryOwner, AppConstant.repositoryName)),

                ["x-language"] = new OpenApiString(AppConstant.projectLang)
            }
        }

    };
}
