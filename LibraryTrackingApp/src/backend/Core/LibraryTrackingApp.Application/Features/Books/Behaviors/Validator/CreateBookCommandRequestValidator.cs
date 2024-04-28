using LibraryTrackingApp.Application.Features.Books.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.Books.Behaviors.Validator;
public class CreateBookCommandRequestValidator : AbstractValidator<CreateBookCommandRequest>
{
    public CreateBookCommandRequestValidator()
    {
        RuleFor(book => book.AudioFilePath).NotEmpty().When(book => book.Format == BookFormat.AudioBook);
        RuleFor(book => book.FilePath).NotEmpty().When(book => book.Format == BookFormat.EBook);

        //geri kalanlarda yazılcaktır.
    }
}
