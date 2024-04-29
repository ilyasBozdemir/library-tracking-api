using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;


namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;

public class TakeBorrowCommandRequest : IRequest<TakeBorrowCommandResponse>
{
    public Guid BorrowId { get; set; }
}