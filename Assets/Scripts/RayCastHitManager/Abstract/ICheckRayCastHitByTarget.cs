using UnityEngine;

namespace RayCastHitManager.Abstract
{
    // 0/2 = 0 stable
    // ByTag, ByType
    public interface ICheckRayCastHitByTarget
    {
        bool IsRayHitByTarget(RaycastHit hit);
    }
}
