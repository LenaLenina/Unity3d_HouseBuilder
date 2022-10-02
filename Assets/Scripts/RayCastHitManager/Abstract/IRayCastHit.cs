using UnityEngine;

namespace RayCastHitManager.Abstract
{
    // 0/3 = 0 stable
    // mouse, screen center, from object to direction
    public interface IRayCastHit
    {
        bool GetHit(out RaycastHit hit);
    }
}