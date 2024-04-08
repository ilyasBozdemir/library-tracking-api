using MediatR;

namespace LibraryTrackingApp.Application.Features.Queries.Book.GetBook;

public class GetBookQueryRequest : IRequest<GetBookQueryResponse>
{
    public Guid BookId { get; set; }
}
