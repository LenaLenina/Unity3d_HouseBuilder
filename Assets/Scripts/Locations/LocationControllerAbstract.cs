using UnityEngine;

namespace Location.Abstract
{
    // 0/3 = 0 stable
    public abstract class LocationControllerAbstract : MonoBehaviour
    {
        public abstract void SetCurrentId(int id);

        public abstract void GoToNextLocation();
    }
}
