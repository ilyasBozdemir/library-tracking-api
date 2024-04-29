
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;

public class ReportDamageBookCommandRequest : IRequest<ReportDamageBookCommandResponse>
{
    public Guid BorrowId { get; set; }
    public string DamageDescription { get; set; }
}
