namespace LibraryTrackingApp.Domain.Entities.Library;

public class BranchHour : BaseEntity<Guid>, IAuditable<Guid>
{
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan OpeningTime { get; set; } 
    public TimeSpan ClosingTime { get; set; }

    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }


    public Guid LibraryBranchId { get; set; }
    public LibraryBranch LibraryBranch { get; set; } 

}

