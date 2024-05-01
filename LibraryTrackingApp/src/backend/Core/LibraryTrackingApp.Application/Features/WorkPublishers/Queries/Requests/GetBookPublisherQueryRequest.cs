using LibraryTrackingApp.Application.Features.WorkPublishers.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.WorkPublishers.Queries.Requests;

public class GetBookPublisherQueryRequest : IRequest<GetBookPublisherQueryResponse>
{
    public Guid BookPublisherId { get; set; }
}
