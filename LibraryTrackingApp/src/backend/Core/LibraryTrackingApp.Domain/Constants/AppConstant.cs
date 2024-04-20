namespace LibraryTrackingApp.Domain.Constants;

public class AppConstant
{
    private const string server = "DESKTOP-R4UP5K6\\SQLEXPRESS";
    private const string database = "LibraryTrackingAppDb";
    private const string integratedSecurity = true ? "True" : "False";
    private const string trustServerCertificate = true ? "True" : "False";

    // case için veritabanı baglantısı gercek projede bu şekilde saklanmaz.
    public const string DefaultConnectionString = $"Server={server};Database={database};Integrated Security={integratedSecurity};TrustServerCertificate={trustServerCertificate};";

    public const string repositoryOwner = "ilyasBozdemir";
    public const string repositoryName = "libraryTrackingApp";
    //repository içinde ki CHANGELOG için versiyonuna göre url templatedir. string.Format() methodu ile format ve arg[] değerleri doldurulcaktır. 
    public const string changelogUrlTemplate = "https://raw.githubusercontent.com/{0}/{1}/main/docs/{2}.0.0/CHANGELOG.md";

    public const string licenseUrlTemplate = "https://raw.githubusercontent.com/{0}/{1}/main/LICENSE";
    public const string termsUrlTemplate = "https://raw.githubusercontent.com/{0}/{1}/main/TERMS.md";

    public const string swaggerUrlTemplate = "/swagger/{0}/swagger.json";

    public const string baseUrlTemplate = "{0}://{1}";

    public const string projectGithubUrl = $"https://github.com/{repositoryOwner}/{repositoryName}";
    public const string projectLogoUrl = $"https://localhost:7115/api/v1/static/api/logo";
    public const string projectLang = $"tr";
    public const string bgColor = $"#fff";
    public const string contactName = $"Kütüphane Destek";
    public const string contactEmail = $"bozdemir.ib70@gmail.com";


    public const string openApiServer = $"https://localhost:7115";
    public const string openApiServer2 = $"http://localhost:5256";

}