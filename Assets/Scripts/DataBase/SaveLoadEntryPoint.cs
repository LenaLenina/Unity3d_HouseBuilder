using UnityEngine;


namespace DataBase
{
    // 4/4 = 1 stable
    public class SaveLoadEntryPoint : MonoBehaviour
    {
        private void Awake()
        {
            SaveEvent.onSaveGame += Save;
            LoadEvent.onLoadGame += Load;
        }

        public void Save(string saveName)
        {
            Global.Save("");
            BuildObjectsDB.Save("");
        }

        public void Load(string loadName)
        {
            Global.Load("");
            BuildObjectsDB.Load("");
        }
    }
}
