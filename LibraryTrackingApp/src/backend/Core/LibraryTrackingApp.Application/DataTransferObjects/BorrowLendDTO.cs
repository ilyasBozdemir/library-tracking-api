

namespace LibraryTrackingApp.Application.DataTransferObjects;

public record BorrowLendDTO : BaseAuditableDTO<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LenderId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public BorrowStatus BorrowStatus { get; set; }
    public bool HasFee { get; set; }
    public decimal FeeAmount { get; set; }

    public DateTime? ReturnDate { get; set; }
    public bool? IsLate { get; set; }
    public int? LateDurationInDays { get; set; }

}
