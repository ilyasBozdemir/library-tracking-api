namespace LibraryTrackingApp.Domain.Constants;

public class AppConstant
{
    // case için veritabanı baglantısı gercek projede bu şekilde saklanmaz.
    public const string DefaultConnectionString = "Server=DESKTOP-R4UP5K6\\SQLEXPRESS;Database=AppIdentityDb;Integrated Security=True;TrustServerCertificate=True;";
    public const string repositoryOwner = "ilyasBozdemir";
    public const string repositoryName = "libraryTrackingApp";
    //repository içinde ki CHANGELOG için versiyonuna göre url templatedir. string.Format() methodu ile format ve arg[] değerleri doldurulcaktır. 
    public const string changelogUrlTemplate = "https://raw.githubusercontent.com/{0}/{1}/main/docs/{2}.0.0/CHANGELOG.md";

    public const string licenseUrlTemplate = "https://raw.githubusercontent.com/{0}/{1}/main/LICENSE";

    public const string swaggerUrlTemplate = "/swagger/{0}/swagger.json";
}
