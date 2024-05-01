using LibraryTrackingApp.Application.Features.WorkGenres.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Queries.Requests;

public class GetAllBookGenresQueryRequest : IRequest<GetAllBookGenresQueryResponse>
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; }
}
