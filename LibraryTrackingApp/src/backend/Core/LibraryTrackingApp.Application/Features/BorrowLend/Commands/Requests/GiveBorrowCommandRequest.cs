using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;
using System.Text.Json.Serialization;


namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;

public class GiveBorrowCommandRequest : IRequest<GiveBorrowCommandResponse>
{
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LenderId { get; set; }

    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public bool HasFee { get; set; }
    public decimal FeeAmount { get; set; }
}
