using UnityEngine;

namespace RayCastHitManager.RayCastHit.ScreenCenter
{
    public class ScreenCenterRayCastHitLimitedDistanceLayerMask : ScreenCenterRayCastHit
    {
        [SerializeField] private float _maxDistance = 2f;
        [SerializeField] private LayerMask _mask;

        public override bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, _maxDistance, _mask);
        }
    }
}
