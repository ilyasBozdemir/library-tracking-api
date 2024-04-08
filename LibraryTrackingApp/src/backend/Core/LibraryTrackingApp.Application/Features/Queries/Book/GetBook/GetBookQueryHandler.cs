namespace LibraryTrackingApp.Application.Features.Queries.Book.GetBook;

public class GetBookQueryHandler : IRequestHandler<GetBookQueryRequest, GetBookQueryResponse>
{
    public GetBookQueryHandler ()
    {
      
    }

    public async Task<GetBookQueryResponse> Handle(GetBookQueryRequest request, CancellationToken cancellationToken)
    {
     
        return new GetBookQueryResponse {  };
    }
}
