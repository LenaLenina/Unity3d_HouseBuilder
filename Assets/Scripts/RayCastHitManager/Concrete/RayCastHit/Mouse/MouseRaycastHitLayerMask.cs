using UnityEngine;

namespace RayCastHitManager.RayCastHit.Mouse
{
    public class MouseRaycastHitLayerMask : MouseRaycastHit
    {
        [SerializeField] private LayerMask _mask;

        public override bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(GetRay(), out hit, Mathf.Infinity, _mask);
        }
    }
}
