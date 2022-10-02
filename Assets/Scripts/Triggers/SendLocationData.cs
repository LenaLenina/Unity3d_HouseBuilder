using Location.Abstract;
using Triggers.Abstract;
using UnityEngine;


namespace Triggers.Concrete
{
    // 2/2 = 1 unstable
    public class SendLocationData : PointTriggerActionAbstract
    {
        [SerializeField] private int _id;

        [SerializeField] private LocationControllerAbstract _locationController;

        void Start()
        {
            _locationController = FindObjectOfType<LocationControllerAbstract>();
        }

        public override void OnEnter()
        {
            _locationController.SetCurrentId(_id);
        }

        public override void OnExit()
        {
            _locationController.SetCurrentId(0);
        }
    }
}
