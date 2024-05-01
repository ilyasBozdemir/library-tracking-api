using LibraryTrackingApp.Application.Features.WorkInventories.Queries.Requests;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Behaviors.Validator;

public class GetBookQueryRequestValidator : AbstractValidator<GetBookQueryRequest>
{
    public GetBookQueryRequestValidator()
    {
        RuleFor(x => x.BookId).NotEmpty();
    }
}

