using LibraryTrackingApp.Application.Features.BookPublishers.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Queries.Requests;

public class GetBookPublisherQueryRequest : IRequest<GetBookPublisherQueryResponse>
{
    public Guid BookPublisherId { get; set; }
}
