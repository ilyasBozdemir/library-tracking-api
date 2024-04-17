using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Behaviors.Validator;


public class CreateLibraryBranchCommandRequestValidator : AbstractValidator<CreateLibraryBranchCommandRequest>
{
    public CreateLibraryBranchCommandRequestValidator()
    {
        RuleFor(x => x.Name).NotNull();
        RuleFor(x => x.Address).NotNull();
        RuleFor(x => x.PhoneNumber).NotNull();
        RuleFor(x => x.Description).NotNull();
    }
}