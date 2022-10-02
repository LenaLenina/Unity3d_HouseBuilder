using TranslatorModule.Abstract;
using TranslatorModule.Enums;
using TranslatorModule.Events;


namespace TranslatorModule.Main
{
    public static class CurrentUIDictionary
    {
        private static AbstractUIDictionary _currentUIDictionary;

        private static UIDictionaries _uIDictionaries;

        private static ILanguageStorage _languageStorage;

        /// <summary>
        /// to subscribe events
        /// </summary>
        public static void Init(ILanguageStorage languageStorage) {
            _languageStorage = languageStorage;

            _uIDictionaries = new UIDictionaries();

            _currentUIDictionary = _uIDictionaries.GetDictionary(_languageStorage.GetLanguage());

            ChangeLanguageEvent.onChangeLanguage += ChangeLanguage;
        }

        public static void ChangeLanguage(GameLanguages language)
        {
            _currentUIDictionary = _uIDictionaries.GetDictionary(language);

            ChangeLanguageEvent.onChangeDictionary?.Invoke();
        }

        public static string GetWord(DictionariesKeys dictionaryKeysEnum)
        {
            return _currentUIDictionary.GetWord(dictionaryKeysEnum);
        }
    }
}
