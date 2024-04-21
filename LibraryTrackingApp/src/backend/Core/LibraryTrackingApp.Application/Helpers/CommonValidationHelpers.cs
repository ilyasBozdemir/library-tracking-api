using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrackingApp.Application.Helpers
{
    /// <summary>
    /// Bu sınıf, genel dosya türü kontrolü ve doğrulama yardımcı metodlarını içerir.
    /// </summary>
    public static class CommonValidationHelpers
    {
        /// <summary>
        /// Belirtilen dosya türünün desteklenip desteklenmediğini kontrol eder.
        /// </summary>
        /// <param name="contentType">Dosya türü içeriği</param>
        /// <returns>Destekleniyorsa true, aksi takdirde false</returns>
        public static bool IsSupportedFileType(string contentType)
        {
            return contentType.Equals("application/pdf") ||
                   contentType.StartsWith("image/");
        }

        /// <summary>
        /// Belirtilen dosya türünün geçerli olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="fileType">Dosya türü</param>
        /// <returns>Geçerliyse true, aksi takdirde false</returns>
        public static bool IsValidFileType(string fileType)
        {
            return !string.IsNullOrWhiteSpace(fileType) &&
                   (fileType.Equals("pdf", StringComparison.OrdinalIgnoreCase) || fileType.StartsWith("image/", StringComparison.OrdinalIgnoreCase));
        }
    }

}
