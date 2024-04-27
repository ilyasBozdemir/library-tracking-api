using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Application.Shared.Wrappers.Results;

namespace LibraryTrackingApp.Application.Features.Books.Queries.Responses;

public class GetAllBooksQueryResponse : PaginatedQueryResult<BookDTO>
{
}
