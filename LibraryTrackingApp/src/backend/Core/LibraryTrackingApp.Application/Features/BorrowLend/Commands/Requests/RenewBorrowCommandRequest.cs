using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;

public class RenewBorrowCommandRequest : IRequest<RenewBorrowCommandResponse>
{
    public Guid BorrowId { get; set; }
    public int RenewalDurationInDays { get; set; }
}
