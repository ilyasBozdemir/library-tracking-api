using LibraryTrackingApp.Domain.Constants;

namespace LibraryTrackingApp.Infrastructure.Repositories;

public class VersionRepository
{
    private readonly Dictionary<string, DateTime> _supportedVersions = new Dictionary<string, DateTime>();

    public VersionRepository()
    {
        _supportedVersions.Add($"v{ApiVersions.V1}", new DateTime(2024, 12, 31));
        //_supportedVersions.Add($"v{ApiVersions.V2}", new DateTime(2025, 12, 31));
    }

    public IDictionary<string, DateTime> GetSupportedVersions()
    {
        return _supportedVersions;
    }
}
