namespace LibraryTrackingApp.Infrastructure.Configuration.ApiDocs;

public class VersionConfig
{
    public List<string> SupportedVersions { get; set; }
    public Dictionary<string, DateTime> VersionSupportEndDate { get; set; }
}
