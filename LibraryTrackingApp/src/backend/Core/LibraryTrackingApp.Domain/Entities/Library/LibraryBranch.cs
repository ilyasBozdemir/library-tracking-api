namespace LibraryTrackingApp.Domain.Entities.Library;


public class LibraryBranch : BaseEntity<Guid>
{
    public string Name { get; set; } // Şubenin adı
    public string Address { get; set; } // Şubenin adresi
    public string PhoneNumber { get; set; } // Şubenin telefon numarası
    public DateTime OpeningDate { get; set; } // Şubenin açılış tarihi
    public string Description { get; set; } // Şube hakkında açıklama

    public ICollection<Book> Books { get; set; } // Şubeye ait kitaplar
    public ICollection<Member> Members { get; set; } // Şubeye kayıtlı üyeler
    public ICollection<Staff> Staff { get; set; } // Şube personeli

    public ICollection<BranchHours> BranchHours { get; set; }
    public ICollection<LibraryTransaction> Transactions { get; set; } // Şube işlemleri
}

