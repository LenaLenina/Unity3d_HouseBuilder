using UnityEngine;

namespace RayCastHitManager.RayCastHit.ScreenCenter
{
    public class ScreenCenterRayCastHitLimitedDistance : ScreenCenterRayCastHit
    {
        [SerializeField] private float _maxDistance = 2f;

        public override bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, _maxDistance);
        }
    }
}
