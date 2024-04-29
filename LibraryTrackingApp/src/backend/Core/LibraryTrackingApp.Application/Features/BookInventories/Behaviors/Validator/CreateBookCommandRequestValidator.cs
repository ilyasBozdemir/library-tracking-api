using LibraryTrackingApp.Application.Features.BookInventories.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.BookInventories.Behaviors.Validator;
public class CreateBookCommandRequestValidator : AbstractValidator<CreateBookCommandRequest>
{
    public CreateBookCommandRequestValidator()
    {
        RuleFor(book => book.AudioFilePath).NotEmpty().When(book => book.Format == BookFormat.AudioBook);
        RuleFor(book => book.FilePath).NotEmpty().When(book => book.Format == BookFormat.EBook);

        //geri kalanlarda yazılcaktır.
    }
}
