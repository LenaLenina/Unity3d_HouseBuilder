using System.Collections.Generic;
using TranslatorModule.Abstract;
using TranslatorModule.Concrete;
using TranslatorModule.Enums;


namespace TranslatorModule.Main
{
    public class UIDictionaries
    {
        private List<IUIDictionaryFactory> _factories = new List<IUIDictionaryFactory>();

        private IUIDictionaryFactory _defaultFactory = new EnglishUIDictionaryFactory();

        public UIDictionaries()
        {
            _factories.Add(new EnglishUIDictionaryFactory());

            _factories.Add(new RussianUIDictionaryFactory());
        }

        private IUIDictionaryFactory GetFactory(GameLanguages language)
        {
            IUIDictionaryFactory result = _defaultFactory;

            foreach (var item in _factories)
            {
                if(item.Language == language)
                {
                    result = item;
                }    
            }

            return result;
        }

        public AbstractUIDictionary GetDictionary(GameLanguages language)
        {
            return GetFactory(language).GreateDictionary();
        }
    }
}
