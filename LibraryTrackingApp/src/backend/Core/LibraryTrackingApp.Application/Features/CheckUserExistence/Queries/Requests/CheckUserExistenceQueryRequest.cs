using LibraryTrackingApp.Application.Features.CheckUserExistence.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.CheckUserExistence.Queries.Requests;

public class CheckUserExistenceQueryRequest:IRequest<CheckUserExistenceQueryResponse>
{
    public string UsernameOrEmail { get; }
}
