using UnityEngine;

namespace RayCastHitManager.RayCastHit.Mouse
{
    public class MouseRaycastHitLimitedDistance : MouseRaycastHit
    {
        [SerializeField] private float _maxDistance = 2f;

        public override bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(GetRay(), out hit, _maxDistance);
        }
    }
}
