using LibraryTrackingApp.Application.Features.BookGenres.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookGenres.Queries.Requests;

public class GetBookGenreQueryRequest : IRequest<GetBookGenreQueryResponse>
{
    public Guid BookGenreId { get; set; }
}
