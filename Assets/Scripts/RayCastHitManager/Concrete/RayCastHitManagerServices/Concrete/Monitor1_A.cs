using UnityEngine;
using RayCastHitManager.RayCastHitManagerServices.Abstract;


namespace RayCastHitManager.RayCastHitManagerServices.Concrete
{
    public class Monitor1_A : IExecuteOperationByKeyCodeOnRayEnter
    {
        public override void OnPressKey()
        {
            transform.parent.gameObject.SetActive(false);

            Destroy(transform.parent.gameObject, 1);
        }
    }
}
