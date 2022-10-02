using UnityEngine;


namespace Triggers.Abstract
{
    // 0/3 = 0 stable
    public abstract class PointTriggerActionAbstract : MonoBehaviour
    {
        public abstract void OnEnter();

        public abstract void OnExit();
    }
}
