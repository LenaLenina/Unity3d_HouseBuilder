using System;
using System.IO;
using TranslatorModule.Enums;
using TranslatorModule.Events;


namespace DataBase
{
    // 5/6 = 0.8 stable
    public static class Global
    {
        static SaveLoadService _saveLoadService = new SaveLoadService(TablesNames.Global);

        public static GameLanguages language = GameLanguages.Rus;

        public static bool autoPlayMusic = true;


        public static int _resolutionIndex = -1;

        public static bool _isFullScreen = true;

        public static int _qualitySettingsLevel = -1;

        public static float _audioVolume = 1;

        static Global()
        {
            ChangeLanguageEvent.onChangeLanguage += ChangeLanguage;
        }

        public static void ChangeLanguage(GameLanguages newlanguage)
        {
            language = newlanguage;
            Save("");
        }

        public static void ChangeAutoPlayMusic(bool value)
        {
            autoPlayMusic = value;
            Save("");
        }

        public static void ChangeResolution(int resolutionIndex)
        {
            _resolutionIndex = resolutionIndex;
            Save("");
        }

        public static void ChangeFullScreen(bool fullScreen)
        {
            _isFullScreen = fullScreen;
            Save("");
        }

        public static void ChangeQualitySettings(int value)
        {
            _qualitySettingsLevel = value;
            Save("");
        }

        public static void ChangeAudioVolume(float value)
        {
            _audioVolume = value;
            Save("");
        }

        public static void Save(string saveName)
        {
            Action<BinaryWriter> actionSave = (bw) =>
            {
                bw.Write((int)language);
                bw.Write(autoPlayMusic);
                bw.Write(_resolutionIndex);
                bw.Write(_isFullScreen);
                bw.Write(_qualitySettingsLevel);
                bw.Write(_audioVolume);
            };

            _saveLoadService.SaveGlobal(actionSave);
        }

        public static void Load(string loadName)
        {
            Action<BinaryReader> actionLoad = (br) =>
            {
                int lang = br.ReadInt32();
                bool inMenu = br.ReadBoolean();

                _resolutionIndex = br.ReadInt32();
                _isFullScreen = br.ReadBoolean();
                _qualitySettingsLevel = br.ReadInt32();
                _audioVolume = br.ReadSingle();

                language = (GameLanguages)lang;
                autoPlayMusic = inMenu;
            };

            _saveLoadService.LoadGlobal(actionLoad);

            ChangeLanguageEvent.onChangeLanguage(language);
        }
    }
}
