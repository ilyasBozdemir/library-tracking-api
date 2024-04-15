using LibraryTrackingApp.Application.Features.Authors.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.Authors.Queries.Requests;

public class GetAllAuthorsQueryRequest : IRequest<GetAllAuthorsQueryResponse>
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; } 
}
