
using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Events;


public class BorrowLendEvent : BaseEvent
{
    public Guid BorrowId { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LenderId { get; set; }
    public BorrowLendType BorrowLendType { get; set; }
}