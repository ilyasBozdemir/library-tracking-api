using LibraryTrackingApp.Application.Features.Books.Queries.Requests;
using LibraryTrackingApp.Application.Features.Books.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.Books.Queries.Handlers;

public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQueryRequest, GetAllBooksQueryResponse>
{
    public GetAllBooksQueryHandler()
    {

    }

    public async Task<GetAllBooksQueryResponse> Handle(GetAllBooksQueryRequest request, CancellationToken cancellationToken)
    {

        return new GetAllBooksQueryResponse { };
    }
}

