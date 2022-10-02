using UnityEngine;


namespace ActionsOnEnableDisableObject.Abstract
{
    // 1/2 = 0.5 stable
    public abstract class ActionsControllerOnEnableDisableObjectAbstract : MonoBehaviour
    {
        [SerializeField] protected ActionsServiceOnEnableDisableObjectAbstract[] _services;

        public void OnEnableObject()
        {
            foreach (var item in _services)
            {
                item.OnEnableObject();
            }
        }

        public void OnDisableObject()
        {
            foreach (var item in _services)
            {
                item.OnDisableObject();
            }
        }
    }
}
