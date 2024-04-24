using LibraryTrackingApp.Domain.Constants;
using LibraryTrackingApp.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

using System.Net;

namespace LibraryTrackingApp.Application.Filters;


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
                HandleExceptionMessage(context, ExceptionMessages.UserAlreadyExistsException, HttpStatusCode.Conflict);
                break;
            case FluentValidation.ValidationException validationException:
                HandleExceptionMessage(context, validationException.Message, HttpStatusCode.BadRequest);
                break;
            case NotFoundException notFoundError:
                HandleExceptionMessage(context, ExceptionMessages.UserNotFoundException, HttpStatusCode.NotFound);
                break;
            case CustomGeneralException customGeneralError:
                HandleExceptionMessage(context, customGeneralError.Message, HttpStatusCode.InternalServerError);
                break;
            case DuplicateEmailException duplicateEmailError:
                HandleExceptionMessage(context, ExceptionMessages.DuplicateEmailException, HttpStatusCode.Conflict);
                break;
            case EmptyException emptyUserError:
                HandleExceptionMessage(context, ExceptionMessages.EmptyUserException, HttpStatusCode.BadRequest);
                break;
            case InvalidException invalidPasswordError:
                HandleExceptionMessage(context, ExceptionMessages.InvalidPasswordException, HttpStatusCode.BadRequest);
                break;
            case LockoutAccountException lockoutAccountError:
                HandleExceptionMessage(context, ExceptionMessages.LockoutAccountException, HttpStatusCode.TooManyRequests);
                break;
            case PasswordChangeFailedException passwordChangeFailedError:
                HandleExceptionMessage(context, ExceptionMessages.PasswordChangeFailedException, HttpStatusCode.BadRequest);
                break;
            case CreateFailedException userCreateFailedError:
                HandleExceptionMessage(context, ExceptionMessages.UserCreateFailedException, HttpStatusCode.InternalServerError);
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
