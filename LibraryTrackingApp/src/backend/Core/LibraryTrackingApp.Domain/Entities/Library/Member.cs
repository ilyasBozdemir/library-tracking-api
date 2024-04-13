namespace LibraryTrackingApp.Domain.Entities.Library;

public class Member : BaseEntity<Guid>, IAuditable<Guid>
{
    public string Name { get; set; } //ad
    public string Email { get; set; } // mail
    public string Address { get; set; } // adres
    public string PhoneNumber { get; set; } // telefon numarası
    public DateTime MembershipDate { get; set; } // Üyelik Tarihi
    public DateTime BirthDate { get; set; } // doğum tarihi
    public bool Gender { get; set; } // cinsiyet
    public string Occupation { get; set; } //Meslek
    public int NumberOfLateReturns { get; set; } // Geciken iade sayısı
    public int MaxLateReturnsAllowed { get; set; } // Maksimum geciken iade sayısı izni
    public bool HasPenalty { get; set; } // Ceza durumu
    public int PenaltyDurationInDays { get; set; } // Ceza süresi (gün cinsinden)
    public bool IsExtensionAllowed { get; set; } // Uzatma izni
    public int ExtensionDurationInDays { get; set; } // Uzatma süresi (gün cinsinden)
    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }



    public Guid BorrowId { get; set; }
    public Guid LibraryBranchId { get; set; }
    public virtual ICollection<LibraryBranch> LibraryBranches { get; set; }
    public virtual ICollection<Borrow> Borrows { get; set; }
}