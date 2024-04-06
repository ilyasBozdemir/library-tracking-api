namespace LibraryTrackingApp.Domain.Entities.Identity;

/*
 * 
 * Admin Rolü: Yönetim işlevlerine tam erişim. Örneğin, kullanıcıları yönetmek, finansal raporlara erişmek, sistem ayarlarını değiştirmek vb.
 * Müşteri Rolü: Genellikle kendi cari hesaplarına, faturalarına ve ödeme bilgilerine erişim.
 * Tedarikçi Rolü: Kendi faturalarını ve cari hesap bilgilerini görebilme, belki de sipariş takibi gibi işlevlere erişim.
 * 
 */

/// <summary>
/// Kimlik doğrulama sistemi içindeki bir rolü temsil eder.
/// <see cref="IdentityRole{TKey}"/> sınıfından türetilmiştir ve Guid tipinde bir anahtar kullanır.
/// Rolün izinleri ile ilişkisini tanımlayan RoleScopes koleksiyonunu içerir.
/// </summary>
public class AppRole : IdentityRole<Guid>
{
    /// <summary>
    /// Role bağlı izinleri tanımlayan Role-Scope ilişkisini temsil eder.
    /// </summary>
    public ICollection<RoleScope> RoleScopes { get; set; }// Role-Scope ilişkisi
}