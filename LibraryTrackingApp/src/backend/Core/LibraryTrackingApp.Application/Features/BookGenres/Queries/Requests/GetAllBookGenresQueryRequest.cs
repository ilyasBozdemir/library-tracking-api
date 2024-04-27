using LibraryTrackingApp.Application.Features.BookGenres.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookGenres.Queries.Requests;

public class GetAllBookGenresQueryRequest : IRequest<GetAllBookGenresQueryResponse>
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; }
}
