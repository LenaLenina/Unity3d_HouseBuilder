using UnityEngine;

namespace RayCastHitManager.RayCastHit.Mouse
{
    public class MouseRaycastHitLimitedDistanceLayerMask : MouseRaycastHit
    {
        [SerializeField] private float _maxDistance = 2f;
        [SerializeField] private LayerMask _mask;

        public override bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(GetRay(), out hit, _maxDistance, _mask);
        }
    }
}
