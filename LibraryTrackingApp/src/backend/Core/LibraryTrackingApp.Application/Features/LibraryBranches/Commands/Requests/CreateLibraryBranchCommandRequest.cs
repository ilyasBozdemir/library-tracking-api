using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;

public class CreateLibraryBranchCommandRequest : IRequest<CreateLibraryBranchCommandResponse>
{
    public string Name { get; init; }
    public string Address { get; init; }
    public string PhoneNumber { get; init; }
    public string Description { get; init; }
}
