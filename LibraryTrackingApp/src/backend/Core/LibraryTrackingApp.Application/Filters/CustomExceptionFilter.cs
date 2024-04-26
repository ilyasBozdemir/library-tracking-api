using LibraryTrackingApp.Domain.Constants;
using LibraryTrackingApp.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

using System.Net;

namespace LibraryTrackingApp.Application.Filters;



/// <summary>
/// Bu filtre, işlem sırasında ortaya çıkan istisnaları işler ve uygun HTTP yanıtlarını oluşturarak istemcilere gönderir.
/// </summary>
///

// proje içinde fırlatılan istisnalar için burada eğer ki, yakalamazsak 500 interval hatası döner....

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case AuthenticationErrorException authenticationError:
                HandleExceptionMessage(context, authenticationError.Message, HttpStatusCode.Unauthorized);
                break;
            case AlreadyExistsException alreadyExistsError:
                HandleExceptionMessage(context, alreadyExistsError.Message, HttpStatusCode.Conflict);
                break;
            case FluentValidation.ValidationException validationException:
                HandleExceptionMessage(context, validationException.Message, HttpStatusCode.BadRequest);
                break;
            case NotFoundException notFoundError:
                HandleExceptionMessage(context, notFoundError.Message, HttpStatusCode.NotFound);
                break;
            case CustomGeneralException customGeneralError:
                HandleExceptionMessage(context, customGeneralError.Message, HttpStatusCode.InternalServerError);
                break;
            case DuplicateEmailException duplicateEmailError:
                HandleExceptionMessage(context, duplicateEmailError.Message, HttpStatusCode.Conflict);
                break;
            case EmptyException emptyUserError:
                HandleExceptionMessage(context, emptyUserError.Message, HttpStatusCode.BadRequest);
                break;
            case InvalidException invalidPasswordError:
                HandleExceptionMessage(context, invalidPasswordError.Message, HttpStatusCode.BadRequest);
                break;
            case LockoutAccountException lockoutAccountError:
                HandleExceptionMessage(context, lockoutAccountError.Message, HttpStatusCode.TooManyRequests);
                break;
            case PasswordChangeFailedException passwordChangeFailedError:
                HandleExceptionMessage(context, passwordChangeFailedError.Message, HttpStatusCode.BadRequest);
                break;
            case CreateFailedException userCreateFailedError:
                HandleExceptionMessage(context, userCreateFailedError.Message, HttpStatusCode.InternalServerError);
                break;
            default:
                HandleExceptionMessage(context, ExceptionMessages.CustomGeneralException, HttpStatusCode.InternalServerError);
                break;
        }
    }

    private static void HandleExceptionMessage(ExceptionContext context, string errorMessage, HttpStatusCode statusCode)
    {
        var response = context.HttpContext.Response;
        response.StatusCode = (int)statusCode;
        response.ContentType = "application/json";
        var err = new { message = errorMessage };
        context.Result = new JsonResult(err);
    }
}
