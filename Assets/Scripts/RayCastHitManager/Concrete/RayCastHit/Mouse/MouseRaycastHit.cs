using RayCastHitManager.Abstract;
using UnityEngine;

namespace RayCastHitManager.RayCastHit.Mouse
{
    public class MouseRaycastHit : MonoBehaviour, IRayCastHit
    {
        public virtual bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(GetRay(), out hit);
        }

        protected Ray GetRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
}
