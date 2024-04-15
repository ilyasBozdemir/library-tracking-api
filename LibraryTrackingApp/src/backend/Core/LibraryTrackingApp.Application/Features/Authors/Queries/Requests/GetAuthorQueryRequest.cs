using LibraryTrackingApp.Application.Features.Authors.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.Authors.Queries.Requests;

public class GetAuthorQueryRequest : IRequest<GetAuthorQueryResponse>
{
    public Guid AuthorId { get; set; }
}