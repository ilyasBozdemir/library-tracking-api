namespace LibraryTrackingApp.Domain.Enums;

//public enum SupportedLanguage
//{
//    tr_TR, // Türkçe
//    en_US, // İngilizce
//}

public class SupportedLanguage
{
    public string IsoCode { get; private set; }
    public string Name { get; private set; }

    private SupportedLanguage(string isoCode, string name)
    {
        IsoCode = isoCode;
        Name = name;
    }

    public static SupportedLanguage Turkish => new SupportedLanguage("tr-TR", "Türkçe");
    public static SupportedLanguage English => new SupportedLanguage("en-US", "İngilizce");
}
