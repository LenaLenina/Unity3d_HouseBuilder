using TranslatorModule.Enums;


namespace TranslatorModule.Abstract
{
    public interface ILanguageStorage
    {
        GameLanguages GetLanguage();
    }
}