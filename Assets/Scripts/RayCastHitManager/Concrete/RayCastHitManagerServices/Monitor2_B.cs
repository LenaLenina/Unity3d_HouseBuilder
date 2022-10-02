using UnityEngine;
using RayCastHitManager.RayCastHitManagerServices.Abstract;

namespace RayCastHitManager.RayCastHitManagerServices
{
    public class Monitor2_B : ExecuteOperationByKeyCodeOnRayEnterBase
    {
        [SerializeField] private IExecuteOperationByKeyCodeOnRayEnter monitor1;

        protected override void OnPressKey()
        {
            monitor1.OnPressKey();
        }
    }
}
