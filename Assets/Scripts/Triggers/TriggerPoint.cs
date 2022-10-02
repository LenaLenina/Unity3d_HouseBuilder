using Triggers.Abstract;
using UnityEngine;


namespace Triggers.Main
{
    // 1/1 = 1 unstable
    public class TriggerPoint : MonoBehaviour
    {
        [SerializeField] private PointTriggerActionAbstract[] _pointActions;

        void Start()
        {
            _pointActions = GetComponents<PointTriggerActionAbstract>();
        }

        public void OnTriggerEnter(Collider other)
        {
            foreach (var item in _pointActions)
            {
                item.OnEnter();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            foreach (var item in _pointActions)
            {
                item.OnExit();
            }
        }
    }
}
