using TranslatorModule.Enums;

namespace TranslatorModule.Abstract
{
    public interface IUIDictionaryFactory
    {
        GameLanguages Language { get; }

        AbstractUIDictionary GreateDictionary();
    }
}
