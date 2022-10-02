using RayCastHitManager.Abstract;
using UnityEngine;


namespace RayCastHitManager.Main
{
    // 2/2 = 1 unstable
    public class RayCastHitManager : MonoBehaviour
    {
        private IRayCastHit _rayCastHit;

        private RayCastHitManagerServiceAbstract _currentHitObject;

        private void Awake()
        {
            _rayCastHit = GetComponent<IRayCastHit>();
        }

        private void Update()
        {
            RaycastHit hit;

            if (_rayCastHit.GetHit(out hit))
            {
                var hitObject = hit.collider.GetComponent<RayCastHitManagerServiceAbstract>();

                if (hitObject != null)
                {
                    OnRayEnter(hitObject);
                }
                else
                {
                    OnRayExit();
                }
            }
            else
            {
                OnRayExit();
            }
        }

        private void OnRayEnter(RayCastHitManagerServiceAbstract hitObject)
        {
            if(hitObject != _currentHitObject)
            {
                OnRayExit();

                _currentHitObject = hitObject;

                _currentHitObject.OnRayEnter();
            }
        }

        private void OnRayExit()
        {
            if(_currentHitObject != null)
            {
                _currentHitObject.OnRayExit();

                _currentHitObject = null;
            }
        }
    }
}
