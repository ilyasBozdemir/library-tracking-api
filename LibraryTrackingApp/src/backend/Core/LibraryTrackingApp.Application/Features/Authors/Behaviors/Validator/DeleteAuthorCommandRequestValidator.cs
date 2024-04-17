using LibraryTrackingApp.Application.Features.Authors.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.Authors.Behaviors.Validator;

public class DeleteAuthorCommandRequestValidator : AbstractValidator<DeleteAuthorCommandRequest>
{
    public DeleteAuthorCommandRequestValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
