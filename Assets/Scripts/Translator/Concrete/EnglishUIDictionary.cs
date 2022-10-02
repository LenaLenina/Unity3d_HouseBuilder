using TranslatorModule.Abstract;
using TranslatorModule.Enums;


namespace TranslatorModule.Concrete
{
    public class EnglishUIDictionary : AbstractUIDictionary
    {
		protected override void AddWords()
        {
			_dictionary.Add(DictionariesKeys.None, "None");
			_dictionary.Add(DictionariesKeys.Save, "Save");
			_dictionary.Add(DictionariesKeys.Load, "Load");
			_dictionary.Add(DictionariesKeys.LanguageMenu, "Language");
			_dictionary.Add(DictionariesKeys.MainMenu, "Main Menu");
			_dictionary.Add(DictionariesKeys.Buy, "Buy");
			_dictionary.Add(DictionariesKeys.Sell, "Sell");
			_dictionary.Add(DictionariesKeys.Close, "Close");
			_dictionary.Add(DictionariesKeys.NewGame, "New Game");
			_dictionary.Add(DictionariesKeys.Continue, "Play");
			_dictionary.Add(DictionariesKeys.Exit, "Exit");
			_dictionary.Add(DictionariesKeys.ConfirmQuitAppText, "Do you really want to quit game?");
			_dictionary.Add(DictionariesKeys.yes, "Yes");
			_dictionary.Add(DictionariesKeys.no, "No");
			_dictionary.Add(DictionariesKeys.ConfirmSaveText, "Do you really want to save game?");
			_dictionary.Add(DictionariesKeys.ConfirmLoadText, "Do you really want to load game?");
			_dictionary.Add(DictionariesKeys.ConfirmNewGameText, "Do you really want to start NEW game? All progress will be lost and it will be impossible to go back!");
			_dictionary.Add(DictionariesKeys.DarkTheme, "Dark Theme");
			_dictionary.Add(DictionariesKeys.PreviousChapter, "Previous Chapter");
			_dictionary.Add(DictionariesKeys.NextChapter, "Next Chapter");
			_dictionary.Add(DictionariesKeys.Chapter, "Chapter");
			_dictionary.Add(DictionariesKeys.Settings, "Settings");
			_dictionary.Add(DictionariesKeys.Music, "Music");
			_dictionary.Add(DictionariesKeys.GoByLink, "Do you really want to go by link?");
			_dictionary.Add(DictionariesKeys.AboutMe, "About me");
			_dictionary.Add(DictionariesKeys.GraphicsText, "Graphics Quality");
			_dictionary.Add(DictionariesKeys.Volume, "Volume");
			_dictionary.Add(DictionariesKeys.RenderDistance, "Render Distance");
			_dictionary.Add(DictionariesKeys.NameOfGame, "       Eliza \n Sea of Secrets");
		}
    }
}
