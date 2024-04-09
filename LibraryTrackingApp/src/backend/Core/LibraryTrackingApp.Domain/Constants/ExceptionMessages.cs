namespace LibraryTrackingApp.Domain.Constants;

public static class ExceptionMessages
{

    // Genel hata mesajları
    public const string GeneralErrorException = "İsteğiniz işlenirken bir hata oluştu.";

    // Özel hata mesajları
    public const string AuthenticationErrorException = "Kimlik doğrulama hatası.";
    public const string CustomGeneralException = "Özelleştirilmiş genel hata.";
    public const string DuplicateEmailException = "E-posta adresi başka bir kullanıcı tarafından kullanılıyor.";
    public const string EmptyUserException = "Kullanıcı bilgileri boş olamaz.";
    public const string PasswordChangeFailedException = "Şifre değişimi başarısız.";
    public const string UserAlreadyExistsException = "Kullanıcı zaten kayıtlı. Hata Kodu: 409";
    public const string UserCreateFailedException = "Kullanıcı oluşturma başarısız.";
    public const string UserNotFoundException = "Kullanıcı bulunamadı.";
    public const string AuthenticationMethodNotFoundException = "Kimlik Doğrulama Methodu bulunamadı.";



    public const string InvalidPasswordException = "Geçersiz şifre.";
    public const string LockoutAccountException = "Hesap kilitlendi.";
    public const string InvalidRefreshTokenException = "Geçersiz Yenileme Tokeni";



}
