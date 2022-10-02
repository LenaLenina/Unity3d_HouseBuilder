using UnityEngine;
using RayCastHitManager.Abstract;

//2/2 = 1
namespace RayCastHitManager.RayCastHitManagerServices
{
    public class ListOfRayCastHitServices : RayCastHitManagerServiceAbstract
    {
        [SerializeField]
        private GameObject _rayCastServices;

        [SerializeField]
        private RayCastHitManagerServiceAbstract[] rayCastHitManagerServices;

        void Start()
        {
            rayCastHitManagerServices = _rayCastServices.GetComponents<RayCastHitManagerServiceAbstract>();
        }

        public override void OnRayEnter()
        {
            foreach (var item in rayCastHitManagerServices)
            {
                item.OnRayEnter();
            }
        }

        public override void OnRayExit()
        {
            foreach (var item in rayCastHitManagerServices)
            {
                item.OnRayExit();
            }
        }
    }
}
