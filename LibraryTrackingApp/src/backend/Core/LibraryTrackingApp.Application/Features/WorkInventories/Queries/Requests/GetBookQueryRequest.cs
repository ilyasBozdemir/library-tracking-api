using LibraryTrackingApp.Application.Features.WorkInventories.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Queries.Requests;

public class GetBookQueryRequest : IRequest<GetBookQueryResponse>
{
    public Guid BookId { get; set; }
}
