using System;
using System.IO;
using UnityEngine;


namespace DataBase
{   
    // 1/14 = 0.07 stable
    public class BuildObjectsDB : MonoBehaviour
    {
        static SaveLoadService _saveLoadService = new SaveLoadService(TablesNames.BuidObjects);

        public static int _buildObjectId = 0;

        public static int _count = 0;

        public static void Save(string saveName)
        {
            Action<BinaryWriter> actionSave = (bw) =>
            {
                bw.Write(_buildObjectId);
                bw.Write(_count);
            };

            _saveLoadService.Save(actionSave, saveName);
        }

        public static void Load(string loadName)
        {
            Action<BinaryReader> actionLoad = (br) =>
            {
                _buildObjectId = br.ReadInt32();
                _count = br.ReadInt32();
            };

            _saveLoadService.Load(actionLoad, loadName);
        }

        public static void Clear()
        {
            _buildObjectId = 0;
            _count = 0;
        }
    }
}
