using RayCastHitManager.Abstract;
using UnityEngine;

namespace RayCastHitManager.RayCastHit.ScreenCenter
{
    public class ScreenCenterRayCastHit : MonoBehaviour, IRayCastHit
    {
        public virtual bool GetHit(out RaycastHit hit)
        {
            return Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit);
        }
    }
}
