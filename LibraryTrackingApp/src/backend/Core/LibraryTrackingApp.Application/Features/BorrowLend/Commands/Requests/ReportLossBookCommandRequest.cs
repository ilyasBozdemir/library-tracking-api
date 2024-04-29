using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;

public class ReportLossBookCommandRequest : IRequest<ReportLossBookCommandResponse>
{
    public Guid BookId { get; set; }
}