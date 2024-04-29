using LibraryTrackingApp.Application.Features.BookInventories.Queries.Requests;

namespace LibraryTrackingApp.Application.Features.BookInventories.Behaviors.Validator;

public class GetBookQueryRequestValidator : AbstractValidator<GetBookQueryRequest>
{
    public GetBookQueryRequestValidator()
    {
        RuleFor(x => x.BookId).NotEmpty();
    }
}

