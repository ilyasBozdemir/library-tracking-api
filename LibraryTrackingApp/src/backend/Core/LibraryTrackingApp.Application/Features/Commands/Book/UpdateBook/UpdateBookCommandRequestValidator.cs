using FluentValidation;

namespace LibraryTrackingApp.Application.Features.Commands.Book.UpdateBook;


public class UpdateBookCommandRequestValidator : AbstractValidator<UpdateBookCommandRequest>
{
    public UpdateBookCommandRequestValidator()
    {

    }
}
