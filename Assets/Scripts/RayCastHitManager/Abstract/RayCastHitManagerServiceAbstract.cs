using UnityEngine;


namespace RayCastHitManager.Abstract
{
    // 0/14 = 0 stable
    // Material, Outline, InfoText, ErrorText, Monitor...
    public abstract class RayCastHitManagerServiceAbstract: MonoBehaviour
    {
        public abstract void OnRayEnter();

        public abstract void OnRayExit();
    }
}