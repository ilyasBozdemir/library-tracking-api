
namespace LibraryTrackingApp.Application.Features.Queries.Book.GetAllBooks;

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

