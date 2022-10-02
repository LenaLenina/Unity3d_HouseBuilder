using System;
using System.IO;
using UnityEngine;


namespace DataBase
{
    public class SaveLoadService
    {
        private readonly string _dbDirectory = "DB";

        private readonly string _globalDirectory = "Global";

        private readonly string _fileName;

        public SaveLoadService(string fileName)
        {
            _fileName = fileName;
        }

        public bool IsSaveExist()
        {
            FileInfo file = new FileInfo(GetPath(""));

            return file.Exists;
        }

        public void CreateSaveDirectory(string saveName)
        {
            DirectoryInfo saveDirectory = new DirectoryInfo(saveName);

            if (!saveDirectory.Exists)
            {
                saveDirectory.Create();
            }
        }

        public void Save(Action<BinaryWriter> action, string saveName)
        {
            FileInfo file = new FileInfo(GetPath(saveName));

            CreateSaveDirectory(file.DirectoryName);

            using (BinaryWriter bw = new BinaryWriter(file.OpenWrite()))
            {
                action(bw);
            }
        }

        public void SaveGlobal(Action<BinaryWriter> action)
        {
            FileInfo file = new FileInfo(GetGlobalPath());

            CreateSaveDirectory(file.DirectoryName);

            using (BinaryWriter bw = new BinaryWriter(file.OpenWrite()))
            {
                action(bw);
            }
        }

        public void Load(Action<BinaryReader> action, string loadName)
        {
            FileInfo file = new FileInfo(GetPath(loadName));

            if (file.Exists)
            {
                try
                {
                    using (BinaryReader br = new BinaryReader(file.OpenRead()))
                    {
                        action(br);
                    }
                }
                catch (Exception ex)
                {
                    var a = ex;
                }
            }
        }

        public void LoadGlobal(Action<BinaryReader> action)
        {
            FileInfo file = new FileInfo(GetGlobalPath());

            if (file.Exists)
            {
                try
                {
                    using (BinaryReader br = new BinaryReader(file.OpenRead()))
                    {
                        action(br);
                    }
                }
                catch (Exception ex)
                {
                    var a = ex;
                }
            }
        }

        private string GetPath(string saveName)
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            return Path.Combine(Application.persistentDataPath, _dbDirectory, saveName, _fileName); // Android

#elif UNITY_WEBGL && !UNITY_EDITOR
            return Path.Combine("/idbfs/AlisaMeyGames/ElizaSeaOfSecrets", _dbDirectory, _fileName);
#else
            return Path.Combine(Application.dataPath, _dbDirectory, saveName, _fileName); // Windows
#endif
        }

        private string GetGlobalPath()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            return Path.Combine(Application.persistentDataPath, _globalDirectory, _fileName); // Android
#elif UNITY_WEBGL && !UNITY_EDITOR
            return Path.Combine("/idbfs/AlisaMeyGames/ElizaSeaOfSecrets", _globalDirectory, _fileName);
#else
            return Path.Combine(Application.dataPath, _globalDirectory, _fileName); // Windows
#endif
        }
    }
}