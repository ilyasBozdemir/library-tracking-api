using LibraryTrackingApp.Application.Features.BorrowLend.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Queries.Requests;

public class GetBorrowByIdQueryRequest:IRequest<GetBorrowByIdQueryResponse>
{
    public Guid BorrowId { get; set; }
}
