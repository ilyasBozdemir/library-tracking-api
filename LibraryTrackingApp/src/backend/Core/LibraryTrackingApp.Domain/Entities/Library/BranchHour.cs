namespace LibraryTrackingApp.Domain.Entities.Library;

public class BranchHour : BaseEntity<Guid>, IAuditable<Guid>
{
    public DayOfWeek DayOfWeek { get; set; } // Haftanın günü
    public TimeSpan OpeningTime { get; set; } // Açılış saati
    public TimeSpan ClosingTime { get; set; } // Kapanış saati
    public bool IsOpen { get; set; } = true;//// Açık mı kapalı mı?

    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    public Guid LibraryBranchId { get; set; } // İlgili şube ID'si
    public LibraryBranch LibraryBranch { get; set; } // İlgili şube
}

