using LibraryTrackingApp.Domain.Constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs.Swagger;

public static class WebApiVersionInfos
{

    public static IEnumerable<ApiVersionInfo> GetAllVersions()
    {
        yield return V1;
    }

    static string repositoryOwner = "ilyasBozdemir";
    static string repositoryName = "libraryTrackingApp";

    public static ApiVersionInfo V1 => new ApiVersionInfo
    {
        Version = $"v{ApiVersions.V1}",
        OpenApiInfo = new OpenApiInfo
        {
            Title = $"Kütüphane Takip API v{ApiVersions.V1}",
            Version = $"v{ApiVersions.V1}",
            Description = @"
             Bu API v1 sürümü, kütüphane takip uygulaması için kapsamlı bir dizi özellik sunmaktadır: \n" +
             "- **Kitap ve Kategori Yönetimi**: Kitapların ve kategorilerin kaydedilmesi, düzenlenmesi ve sorgulanması.\n" +
             "- **Üye Yönetimi**: Kütüphane üyelerinin kaydedilmesi ve takibi.\n" +
             "- **Ödünç Alma ve İade İşlemleri**: Kitap ödünç alma, iade etme ve süre uzatma işlemleri.\n" +
             "- **Personel Yönetimi**: Kütüphane personelinin yönetimi ve yetkilendirilmesi.\n" +
             "- **Kütüphane İşlemleri Takibi**: Kütüphane içi işlemlerin detaylı kaydı ve raporlanması.\n" +
             "- **Yönetim ve Raporlama Araçları**: Kapsamlı yönetim ve raporlama araçları.\n" +
             "- **Kullanıcı Hesapları ve İzinler**: Çok kullanıcılı hesap yönetimi ve rol bazlı erişim kontrolleri.",
            Contact = new OpenApiContact
            {
                Name = "Kütüphane Destek Ekibi",
                Email = "destek@domain.com"
            },
            License = new OpenApiLicense
            {
                Name = "API Lisansı",
                Url = new Uri($"https://raw.githubusercontent.com/{repositoryOwner}/{repositoryName}/main/LICENSE")
            }
        }

    };

}
