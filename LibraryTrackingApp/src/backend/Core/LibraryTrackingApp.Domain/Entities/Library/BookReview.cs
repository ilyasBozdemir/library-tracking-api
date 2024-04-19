namespace LibraryTrackingApp.Domain.Entities.Library;

public class BookReview : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public string ReviewText { get; set; }
    public int Rating { get; set; } // Rating out of 5 or 10
    public DateTime ReviewDate { get; set; }
}
