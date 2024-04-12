using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs;

namespace LibraryTrackingApp.Infrastructure.Services;

public class VersionService
{
    private readonly Dictionary<string, VersionInfo> _versions;

    public VersionService()
    {
        _versions = new Dictionary<string, VersionInfo>();
    }

    public void AddVersion(string version, VersionInfo versionInfo)
    {
        _versions[version] = versionInfo;
    }

    public bool UpdateVersion(string version, VersionInfo versionInfo)
    {
        if (_versions.ContainsKey(version))
        {
            _versions[version] = versionInfo;
            return true;
        }
        return false;
    }

    public bool DeleteVersion(string version)
    {
        return _versions.Remove(version);
    }

    public VersionInfo GetVersionInfo(string version)
    {
        return _versions.TryGetValue(version, out VersionInfo versionInfo) ? versionInfo : null;
    }

    public IEnumerable<string> GetAllVersions()
    {
        return _versions.Keys;
    }

    public IEnumerable<string> GetSupportedVersions(DateTime currentDate)
    {
        return _versions
            .Where(kv => kv.Value.SupportEndDate >= currentDate)
            .Select(kv => kv.Key);
    }
}
