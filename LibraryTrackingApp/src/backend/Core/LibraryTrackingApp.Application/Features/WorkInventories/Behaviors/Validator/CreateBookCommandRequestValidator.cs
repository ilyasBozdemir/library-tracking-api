using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Behaviors.Validator;
public class CreateBookCommandRequestValidator : AbstractValidator<CreateBookCommandRequest>
{
    public CreateBookCommandRequestValidator()
    {
        RuleFor(book => book.AudioFilePath).NotEmpty().When(book => book.Format == WorkFormat.AudioBook);
        RuleFor(book => book.FilePath).NotEmpty().When(book => book.Format == WorkFormat.EBook);

        //geri kalanlarda yazılcaktır.
    }
}
