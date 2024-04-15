using LibraryTrackingApp.Application.Features.Books.Queries.Requests;
using LibraryTrackingApp.Application.Features.Books.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.Books.Queries.Handlers;

public class GetBookQueryHandler : IRequestHandler<GetBookQueryRequest, GetBookQueryResponse>
{
    public GetBookQueryHandler()
    {

    }

    public async Task<GetBookQueryResponse> Handle(GetBookQueryRequest request, CancellationToken cancellationToken)
    {

        return new GetBookQueryResponse { };
    }
}
