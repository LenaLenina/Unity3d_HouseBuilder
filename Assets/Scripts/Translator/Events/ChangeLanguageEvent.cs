using System;
using TranslatorModule.Enums;


namespace TranslatorModule.Events
{
    public class ChangeLanguageEvent
    {
        public static Action<GameLanguages> onChangeLanguage;

        public static Action onChangeDictionary;
    }
}
