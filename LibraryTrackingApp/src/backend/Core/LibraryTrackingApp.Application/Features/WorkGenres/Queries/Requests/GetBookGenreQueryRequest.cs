using LibraryTrackingApp.Application.Features.WorkGenres.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Queries.Requests;

public class GetBookGenreQueryRequest : IRequest<GetBookGenreQueryResponse>
{
    public Guid BookGenreId { get; set; }
}
