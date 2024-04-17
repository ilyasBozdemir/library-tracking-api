using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;

public class UpdateLibraryBranchCommandRequest:IRequest<UpdateLibraryBranchCommandResponse>
{
    public Guid UpdatedId { get; set; }
    public string Name { get; init; }
    public string Address { get; init; }
    public string PhoneNumber { get; init; }
    public string Description { get; init; }
}
