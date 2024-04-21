namespace LibraryTrackingApp.Application.Helpers.Filters.Enums;

/// <summary>
/// Filtre operatörleri.
/// </summary>
[Flags]
public enum FilterOperator
{
    IsLessThan,// Değeri verilenden küçük olanları alır.
    IsLessThanOrEqualTo,// Değeri verilenden küçük veya buna eşit olanları alır.
    IsEqualTo,// Değeri verilene eşit olanları alır.
    IsNotEqualTo,// Değeri verilene eşit olmayanları alır.
    IsGreaterThanOrEqualTo,// Değeri verilenden büyük veya buna eşit olanları alır.
    IsGreaterThan,// Değeri verilenden büyük olanları alır.
    StartsWith,// Belirtilen metinle başlayanları alır.
    EndsWith,// Belirtilen metinle bitenleri alır.
    Contains,// Belirtilen metni içerenleri alır.
    DoesNotContain,// Belirtilen metni içermeyenleri alır.
    IsNull,// Değeri null olanları alır.
    IsNotNull,// Değeri null olmayanları alır.
    IsEmpty,// Boş olanları alır.
    IsNotEmpty,// Boş olmayanları alır.
    TextSearch,// Metin tabanlı arama yapar.
    IsBetween,// Belirtilen aralıkta olanları alır.
    In,// Belirtilen listeye dahil olanları alır.
    NotIn// Belirtilen listede olmayanları alır.
}
