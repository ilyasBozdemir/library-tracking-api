using LibraryTrackingApp.Application.Features.WorkInventories.Queries.Requests;
using LibraryTrackingApp.Application.Features.WorkInventories.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Queries.Handlers;

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

