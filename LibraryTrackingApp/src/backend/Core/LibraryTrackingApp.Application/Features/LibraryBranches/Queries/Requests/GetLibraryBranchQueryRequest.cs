using LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Requests;

public class GetLibraryBranchQueryRequest : IRequest<GetLibraryBranchQueryResponse>
{
    public Guid LibraryBranchId { get; set; }
}