using LibraryTrackingApp.Application.Features.BookInventories.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookInventories.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookInventories.Queries.Handlers;

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

