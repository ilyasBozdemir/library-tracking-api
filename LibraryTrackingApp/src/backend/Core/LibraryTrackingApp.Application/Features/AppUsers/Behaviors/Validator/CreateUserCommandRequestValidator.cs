using LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.AppUsers.Behaviors.Validator;
public class CreateUserCommandRequestValidator : AbstractValidator<CreateUserCommandRequest>
{
    public CreateUserCommandRequestValidator()
    {
        RuleFor(x => x.Username)
            .NotEmpty()
            .WithMessage("Kullanıcı adı boş olamaz");

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Geçerli bir e-posta adresi giriniz");

        RuleFor(x => x.TelNumber)
           .NotEmpty()
           .WithMessage("Telefon numarası boş olamaz.");

        RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş olamaz");
    }
    private bool BeAValidPhoneNumber(string telNumber)
    {
        return !string.IsNullOrEmpty(telNumber) && telNumber.Length >= 10;// 555 333 00 11 -> 10 karakter 
    }
}
