using TranslatorModule.Abstract;
using TranslatorModule.Enums;


namespace TranslatorModule.Concrete
{
    public class RussianUIDictionary : AbstractUIDictionary
    {
        protected override void AddWords()
        {
			_dictionary.Add(DictionariesKeys.None, "None");
			_dictionary.Add(DictionariesKeys.Save, "Сохранить");
			_dictionary.Add(DictionariesKeys.Load, "Загрузка");
			_dictionary.Add(DictionariesKeys.LanguageMenu, "Язык");
			_dictionary.Add(DictionariesKeys.MainMenu, "Меню");
			_dictionary.Add(DictionariesKeys.Buy, "Купить");
			_dictionary.Add(DictionariesKeys.Sell, "Продать");
			_dictionary.Add(DictionariesKeys.Close, "Закрыть");
			_dictionary.Add(DictionariesKeys.NewGame, "Новая игра");
			_dictionary.Add(DictionariesKeys.Continue, "Продолжить");
			_dictionary.Add(DictionariesKeys.Exit, "Выход");
			_dictionary.Add(DictionariesKeys.ConfirmQuitAppText, "Вы действительно хотите выйти из игры?");
			_dictionary.Add(DictionariesKeys.yes, "Да");
			_dictionary.Add(DictionariesKeys.no, "Нет");
			_dictionary.Add(DictionariesKeys.ConfirmSaveText, "Вы действительно хотите сохранить игру?");
			_dictionary.Add(DictionariesKeys.ConfirmLoadText, "Вы действительно хотите загрузить игру?");
			_dictionary.Add(DictionariesKeys.ConfirmNewGameText, "Вы действительно хотите начать НОВУЮ игру? Весь прогресс будет потерян и назад вернуться будет нельзя!");
			_dictionary.Add(DictionariesKeys.DarkTheme, "Темная тема");
			_dictionary.Add(DictionariesKeys.PreviousChapter, "Предыдущая глава");
			_dictionary.Add(DictionariesKeys.NextChapter, "Следующая глава");
			_dictionary.Add(DictionariesKeys.Chapter, "Глава");
			_dictionary.Add(DictionariesKeys.Settings, "Настройки");
			_dictionary.Add(DictionariesKeys.Music, "Музыка");
			_dictionary.Add(DictionariesKeys.GoByLink, "Вы действительно хотите перейти по ссылке?");
			_dictionary.Add(DictionariesKeys.AboutMe, "Oбо мне");
			_dictionary.Add(DictionariesKeys.GraphicsText, "Качество графики");
			_dictionary.Add(DictionariesKeys.Volume, "Громкость");
			_dictionary.Add(DictionariesKeys.RenderDistance, "Дальность прорисовки");
			_dictionary.Add(DictionariesKeys.NameOfGame, "         Элиза \n и Mоре Cекретов");
		}
    }
}
