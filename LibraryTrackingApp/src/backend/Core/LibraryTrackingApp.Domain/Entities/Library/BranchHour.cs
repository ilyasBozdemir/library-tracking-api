namespace LibraryTrackingApp.Domain.Entities.Library;

public class BranchHour : BaseEntity<Guid>
{
    public DayOfWeek DayOfWeek { get; set; } // Haftanın günü
    public TimeSpan OpeningTime { get; set; } // Açılış saati
    public TimeSpan ClosingTime { get; set; } // Kapanış saati

    public Guid LibraryBranchId { get; set; } // İlgili şube ID'si
    public LibraryBranch LibraryBranch { get; set; } // İlgili şube
}

