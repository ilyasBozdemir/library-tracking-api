using LibraryTrackingApp.Domain.Exceptions;

namespace LibraryTrackingApp.Application.Behaviors;


/// <summary>
/// Bu davranış, işlem sırasında ortaya çıkan istisnaları ele alır ve uygun şekilde işler.
/// İşlemi işlemeye başlamadan önce gelen isteği işler ve iş mantığını yürütürken ortaya çıkabilecek istisnaları ele alır.
/// Bu davranış, istisna durumlarını loglamak, uygun hata mesajlarını oluşturmak ve uygun şekilde işlemek gibi işlemleri gerçekleştirmek için idealdir.
/// </summary>
/// <typeparam name="TRequest">İşlenecek istek türü.</typeparam>
/// <typeparam name="TResponse">İşlem sonucu olarak döndürülecek yanıt türü.</typeparam>
/// <seealso cref="LibraryTrackingApp.Application.Filters.CustomExceptionFilter"/> 
/// <remarks>
/// Bu davranış genellikle MediatR kütüphanesiyle birlikte kullanılır.
/// İlgili istisnalar bu davranışta yakalanır ve işlenir.
/// Loglama ve diğer yapılar için bu davranışı kullanabilirsiniz.
/// </remarks>



public class ExceptionHandlingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            // Handler'ı çağır ve response'ı al
            return await next();
        }
        catch (AuthenticationErrorException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"AuthenticationErrorException: {ex.Message}");
            throw new AuthenticationErrorException(ex.Message);
        }
        catch (AlreadyExistsException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"UserAlreadyExistsException: {ex.Message}");
            throw new AlreadyExistsException(ex.Message);
        }
        catch (FluentValidation.ValidationException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"ValidationException: {ex.Message}");
            throw new ValidationException(ex.Message);
        }
        catch (CustomGeneralException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"CustomGeneralException: {ex.Message}");
            throw new CustomGeneralException(ex.Message, ex);
        }
        catch (NotFoundException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"UserNotFoundException: {ex.Message}");
            throw new NotFoundException(ex.Message);
        }
        catch (DuplicateEmailException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"DuplicateEmailException: {ex.Message}");
            throw new DuplicateEmailException(ex.Message);
        }
        catch (EmptyException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"EmptyUserException: {ex.Message}");
            throw new EmptyException(ex.Message);
        }
        catch (InvalidException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"InvalidPasswordException: {ex.Message}");
            throw new InvalidException(ex.Message);
        }
        catch (LockoutAccountException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"LockoutAccountException: {ex.Message}");
            throw new LockoutAccountException(ex.Message);
        }
        catch (PasswordChangeFailedException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"PasswordChangeFailedException: {ex.Message}");
            throw new PasswordChangeFailedException(ex.Message);
        }
        catch (CreateFailedException ex)
        {
            // Özel hata işleme
            Console.WriteLine($"UserCreateFailedException: {ex.Message}");
            throw new CreateFailedException(ex.Message);
        }
        catch (Exception ex)
        {
            // Genel hata işleme
            Console.WriteLine($"General Exception: {ex.Message}");
            throw new CustomGeneralException("An error occurred during processing your request.", ex);
        }
    }
}
