using LibraryTrackingApp.Application.Features.WorkGenres.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.WorkPublishers.Queries.Requests;

public class GetAllBookPublishersQueryRequest : IRequest<GetAllBookGenresQueryResponse>
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; }
}
