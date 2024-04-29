namespace LibraryTrackingApp.Domain.Entities.Library;

// şubeleri aslında appusere baglayıp appuserin yani adminin subeleri olması lazım.
// sonra ki guncellemede gelicektir.
public class LibraryBranch : BaseEntity<Guid>, IAuditable<Guid>
{
    public string Name { get; set; } // Şubenin adı
    public string Address { get; set; } // Şubenin adresi
    public string PhoneNumber { get; set; } // Şubenin telefon numarası
    public string Description { get; set; } // Şube hakkında açıklama


    public int MaxCheckoutLimit { get; set; } // Azami ödünç alma adedi
    public int MinCheckoutDurationInDays { get; set; } // Asgari teslim süresi (gün cinsinden)
    public int MaxCheckoutDurationInDays { get; set; } // Azami teslim süresi (gün cinsinden)
    public int CriticalLevelThreshold { get; set; } // Eser kritik seviyesi

    public bool NotifyOnBookOrBlogComment { get; set; } // Eser veya blog yorumu bildirimi açık mı?

    public int TopMembersReportLimit { get; set; } // En çok okuyan üyeler raporunda listelenecek maksimum üye sayısı
    public int TopBooksReportLimit { get; set; } // En çok okuyan eserler raporunda listelenecek maksimum eser sayısı



    public ICollection<BookCatalog> Books { get; set; } // Şubeye ait kitaplar
    public ICollection<Member> Members { get; set; } // Şubeye kayıtlı üyeler
    public ICollection<Staff> Staffs { get; set; } // Şube personeli
    public ICollection<BranchHour> BranchHours { get; set; } // mesai saatleri
    public ICollection<LibraryTransaction> Transactions { get; set; } // Şube işlemleri
}
