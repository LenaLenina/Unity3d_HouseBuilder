using UnityEngine;

namespace RayCastHitManager.RayCastHitManagerServices
{
    public class Monitor2_A : ExecuteOperationByKeyCodeOnRayEnterBase
    {
        protected override void OnPressKey()
        {
            Debug.Log("Monitor 2_A operation");
        }
    }
}
