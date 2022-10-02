using UnityEngine;

namespace RayCastHitManager.RayCastHit.ScreenCenter
{
    public class ScreenCenterRayCastHitLayerMask : ScreenCenterRayCastHit
    {
        [SerializeField] private LayerMask _mask;

        public override bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity, _mask);
        }
    }
}
