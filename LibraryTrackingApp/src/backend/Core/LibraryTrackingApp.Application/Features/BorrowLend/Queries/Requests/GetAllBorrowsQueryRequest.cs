using LibraryTrackingApp.Application.Features.BorrowLend.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Queries.Requests;

public class GetAllBorrowsQueryRequest:IRequest<GetAllBorrowsQueryResponse>
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; }
}