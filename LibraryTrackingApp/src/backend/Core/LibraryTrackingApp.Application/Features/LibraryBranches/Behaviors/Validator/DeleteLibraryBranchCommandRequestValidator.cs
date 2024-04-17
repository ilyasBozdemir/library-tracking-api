using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Behaviors.Validator;


public class DeleteLibraryBranchCommandRequestValidator : AbstractValidator<DeleteLibraryBranchCommandRequest>
{
    public DeleteLibraryBranchCommandRequestValidator()
    {
        RuleFor(x => x.Id).NotNull();
}
}