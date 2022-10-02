using Triggers.Abstract;
using UnityEngine;
using Views.Abstract;


namespace Triggers.Concrete
{
    // 2/2 = 1 unstable
    public class LocationViewOpen : PointTriggerActionAbstract
    {
        [SerializeField] private View _view;

        public override void OnEnter()
        {
            _view.gameObject.SetActive(true);
        }

        public override void OnExit()
        {
            _view.gameObject.SetActive(false);
        }
    }
}
