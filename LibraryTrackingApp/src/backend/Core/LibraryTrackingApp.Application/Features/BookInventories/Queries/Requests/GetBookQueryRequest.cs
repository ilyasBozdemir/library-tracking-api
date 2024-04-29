using LibraryTrackingApp.Application.Features.BookInventories.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookInventories.Queries.Requests;

public class GetBookQueryRequest : IRequest<GetBookQueryResponse>
{
    public Guid BookId { get; set; }
}
