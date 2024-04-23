using LibraryTrackingApp.Application.Shared.Wrappers.Results;

namespace LibraryTrackingApp.Application.Features.CheckUserExistence.Queries.Responses;

public class CheckUserExistenceQueryResponse:QueryResult
{
    public bool StatusResult { get; set; }
}
