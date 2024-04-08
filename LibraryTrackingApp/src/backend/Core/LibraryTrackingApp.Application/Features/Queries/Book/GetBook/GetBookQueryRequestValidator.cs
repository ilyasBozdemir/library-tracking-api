using FluentValidation;


namespace LibraryTrackingApp.Application.Features.Queries.Book.GetBook;

public class GetBookQueryRequestValidator : AbstractValidator<GetBookQueryRequest>
{
    public GetBookQueryRequestValidator()
    {
        RuleFor(x => x.BookId).NotEmpty();
    }
}

