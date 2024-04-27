using LibraryTrackingApp.Application.Features.BookGenres.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Queries.Requests;

public class GetAllBookPublishersQueryRequest : IRequest<GetAllBookGenresQueryResponse>
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; }
}
