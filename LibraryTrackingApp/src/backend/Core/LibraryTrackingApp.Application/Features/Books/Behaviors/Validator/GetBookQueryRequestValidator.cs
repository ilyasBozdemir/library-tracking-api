using LibraryTrackingApp.Application.Features.Books.Queries.Requests;

namespace LibraryTrackingApp.Application.Features.Books.Behaviors.Validator;

public class GetBookQueryRequestValidator : AbstractValidator<GetBookQueryRequest>
{
    public GetBookQueryRequestValidator()
    {
        RuleFor(x => x.BookId).NotEmpty();
    }
}

