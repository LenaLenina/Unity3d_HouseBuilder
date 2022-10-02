using RayCastHitManager.Abstract;
using UnityEngine;

namespace RayCastHitManager.CheckRayHitByTarget
{
    public class CheckRayHitByTargetTypeBase<T> : MonoBehaviour, ICheckRayCastHitByTarget
    {
        public bool IsRayHitByTarget(RaycastHit hit)
        {
            var go = hit.collider.GetComponent<T>();

            if (go != null)
            {
                return true;
            }

            return false;
        }
    }
}
