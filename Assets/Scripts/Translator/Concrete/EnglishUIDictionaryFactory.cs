using TranslatorModule.Abstract;
using TranslatorModule.Enums;


namespace TranslatorModule.Concrete
{
    public class EnglishUIDictionaryFactory : IUIDictionaryFactory
    {
        public GameLanguages Language => GameLanguages.En;

        public AbstractUIDictionary GreateDictionary()
        {
            return new EnglishUIDictionary();
        }
    }
}
