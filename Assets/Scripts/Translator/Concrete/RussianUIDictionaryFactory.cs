using TranslatorModule.Abstract;
using TranslatorModule.Enums;


namespace TranslatorModule.Concrete
{
    public class RussianUIDictionaryFactory : IUIDictionaryFactory
    {
        public GameLanguages Language => GameLanguages.Rus;

        public AbstractUIDictionary GreateDictionary()
        {
            return new RussianUIDictionary();
        }
    }
}
