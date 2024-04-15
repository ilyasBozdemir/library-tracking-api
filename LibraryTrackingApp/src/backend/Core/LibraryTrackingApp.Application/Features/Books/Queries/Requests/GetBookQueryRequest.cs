using LibraryTrackingApp.Application.Features.Books.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.Books.Queries.Requests;

public class GetBookQueryRequest : IRequest<GetBookQueryResponse>
{
    public Guid BookId { get; set; }
}
