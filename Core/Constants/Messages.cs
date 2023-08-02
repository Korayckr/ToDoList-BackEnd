namespace Core.Constants;

public static class Messages
{
    // META
    public const string YouCantDoThat = "Bu işlemi yapamazsınız";
    public const string Success = "İşlem başarıyla tamamlandı";
    public const string NotFound = "Kayıt bulunamadı";
    public const string Error = "Hata alındı";

    // AUTH SERVICE
    public const string RefreshTokenNotValid = "Refresh Token Geçerli Değil";
    public const string EmailAlreadyTaken = "Bu Email Zaten Alınmış";
    public const string UserNameAlreadyTaken = "Bu Kullanıcı Adı Zaten Alınmış";
    public const string UserNameOrPasswordWrong = "Kullanıcı Adı veya Şifre Yanlış";

    // Entity Service
    public const string SuccessfullyCreatedEntity = "Entity Başarıyla Oluşturuldu";
    public const string SuccessfullyUpdatedEntity = "Entity Başarıyla Güncellendi";
    public const string SuccessfullyDeletedEntity = "Entity Başarıyla Silindi";
}