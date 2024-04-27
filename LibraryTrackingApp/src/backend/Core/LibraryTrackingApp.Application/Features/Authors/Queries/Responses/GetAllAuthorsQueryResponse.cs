using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Application.Shared.Wrappers.Results;

namespace LibraryTrackingApp.Application.Features.Authors.Queries.Responses;

public class GetAllAuthorsQueryResponse : PaginatedQueryResult<AuthorDTO>
{
}
