using LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Requests;

public class GetAllLibraryBranchesQueryRequest: IRequest<GetAllLibraryBranchesQueryResponse>
{
    public int PageSize { get; set; }
    public int PageIndex { get; set; }
}
