using RayCastHitManager.Abstract;
using UnityEngine;

namespace RayCastHitManager.CheckRayHitByTarget
{
    public class CheckRayHitByTargetTag : MonoBehaviour, ICheckRayCastHitByTarget
    {
        [SerializeField] private string selectableTag = "Selectable";

        public bool IsRayHitByTarget(RaycastHit hit)
        {
            return hit.transform.CompareTag(selectableTag);
        }
    }
}
