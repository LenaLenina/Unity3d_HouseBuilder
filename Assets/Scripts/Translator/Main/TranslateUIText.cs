using TranslatorModule.Events;
using TranslatorModule.Abstract;
using TranslatorModule.Enums;
using UnityEngine;
using UnityEngine.UI;


namespace TranslatorModule.Main
{
    [RequireComponent(typeof(Text))]
    public class TranslateUIText : MonoBehaviour
    {
        [SerializeField] private DictionariesKeys languageKeysEnum = DictionariesKeys.Load;

        private Text _text;

        private void Awake()
        {
            _text = GetComponent<Text>();
        }

        void Start()
        {
            SetText();
            ChangeLanguageEvent.onChangeDictionary += SetText;
        }

        public void SetText()
        {
            _text.text = CurrentUIDictionary.GetWord(languageKeysEnum);
        }
    }
}