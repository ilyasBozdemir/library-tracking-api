using LibraryTrackingApp.Infrastructure.Enums;
using System.Reflection;

namespace LibraryTrackingApp.Infrastructure.Helpers;

/// <summary>
/// Yardımcı sınıf, katmanların Assembly bilgisini yönetir.
/// </summary>
public static class AssemblyHelper
{
    private static readonly Dictionary<LayerName, Assembly> LayerAssemblies = new Dictionary<LayerName, Assembly>();

    /// <summary>
    /// Belirtilen katman adı ve Assembly ile birlikte kaydedilir.
    /// </summary>
    /// <param name="layerName">Kaydedilecek katman adı.</param>
    /// <param name="assembly">Kaydedilecek Assembly.</param>
    public static void RegisterLayerAssembly(LayerName layerName, Assembly assembly)
    {
        LayerAssemblies[layerName] = assembly;
    }

    /// <summary>
    /// Belirtilen katmanın Assembly'sini alır.
    /// </summary>
    /// <param name="layerName">Assembly'si alınacak katmanın adı.</param>
    /// <returns>Belirtilen katmanın Assembly'si.</returns>
    /// <exception cref="ArgumentException">Geçersiz katman adı durumunda fırlatılır.</exception>
    public static Assembly GetLayerAssembly(LayerName layerName)
    {
        if (LayerAssemblies.TryGetValue(layerName, out Assembly assembly))
        {
            return assembly;
        }
        else
        {
            throw new ArgumentException($"{nameof(layerName)} katmanı kayıt edilmemiş.");
        }
    }
}
