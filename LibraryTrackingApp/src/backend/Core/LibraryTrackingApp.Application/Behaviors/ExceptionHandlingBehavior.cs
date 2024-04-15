using LibraryTrackingApp.Domain.Exceptions;


namespace LibraryTrackingApp.Application.Behaviors;

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
        catch (ValidationException ex)
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
        // Diğer özel istisnaları buraya ekleyebilirsiniz.
        // Örneğin:
        catch (LockoutAccountException ex)
        {
            Console.WriteLine($"LockoutAccountException: {ex.Message}");
            throw new LockoutAccountException(ex.Message);
        }
        catch (InvalidException ex)
        {
            Console.WriteLine($"InvalidPasswordException: {ex.Message}");
            throw new InvalidException(ex.Message);
        }

        catch (Exception ex)
        {
            // Genel hata işleme
            Console.WriteLine($"General Exception: {ex.Message}");
            throw new CustomGeneralException("An error occurred during processing your request.", ex);
        }
    }
}
