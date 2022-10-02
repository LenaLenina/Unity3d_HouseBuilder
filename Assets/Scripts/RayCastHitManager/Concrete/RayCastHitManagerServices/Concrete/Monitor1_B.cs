using UnityEngine;
using RayCastHitManager.RayCastHitManagerServices.Abstract;


namespace RayCastHitManager.RayCastHitManagerServices.Concrete
{
    public class Monitor1_B : IExecuteOperationByKeyCodeOnRayEnter
    {
        public override void OnPressKey()
        {
            Debug.Log("Monitor 1_B operation");
        }
    }
}
