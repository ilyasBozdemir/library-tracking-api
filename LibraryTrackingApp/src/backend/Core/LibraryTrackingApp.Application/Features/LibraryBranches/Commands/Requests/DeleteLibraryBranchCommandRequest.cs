using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;

public class DeleteLibraryBranchCommandRequest: IRequest<DeleteLibraryBranchCommandResponse>
{
    public string Id { get; set; }
}
