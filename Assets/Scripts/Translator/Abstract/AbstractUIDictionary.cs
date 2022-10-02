using System.Collections.Generic;
using TranslatorModule.Enums;


namespace TranslatorModule.Abstract
{
    public abstract class AbstractUIDictionary
    {
        protected Dictionary<DictionariesKeys, string> _dictionary = new Dictionary<DictionariesKeys, string>();

        public AbstractUIDictionary()
        {
            AddWords();
        }

        public string GetWord(DictionariesKeys dictionaryKeysEnum)
        {
            return _dictionary[dictionaryKeysEnum];
        }

        protected abstract void AddWords();
    }
}
