namespace LibraryTrackingApp.Domain.Entities.Library;


public class LibraryBranch : BaseEntity<Guid>, IAuditable<Guid>
{
    public string Name { get; set; } // Şubenin adı
    public string Address { get; set; } // Şubenin adresi
    public string PhoneNumber { get; set; } // Şubenin telefon numarası
    public DateTime OpeningDate { get; set; } // Şubenin açılış tarihi
    public string Description { get; set; } // Şube hakkında açıklama

    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }


    public Guid BookId { get; set; }
    public Guid BranchHourId { get; set; }
    public Guid MemberId { get; set; }
    public Guid StaffId { get; set; }
    public Guid LibraryBranchId { get; set; }
    public Guid LibraryTransactionId { get; set; }




    public ICollection<Book> Books { get; set; } // Şubeye ait kitaplar
    public ICollection<Member> Members { get; set; } // Şubeye kayıtlı üyeler
    public ICollection<Staff> Staffs { get; set; } // Şube personeli
    public ICollection<BranchHour> BranchHours { get; set; } // mesai saatleri
    public ICollection<LibraryTransaction> Transactions { get; set; } // Şube işlemleri
}

