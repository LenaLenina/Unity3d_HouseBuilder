using ActionsOnEnableDisableObject.Abstract;
using UnityEngine;


namespace RayCastHitManager.Components.Scene
{
    // 1/1 = 1 unstable
    public class RayCastHitManagerSceneStart : MonoBehaviour
    {
        [SerializeField] private ActionsServiceOnEnableDisableObjectAbstract _cursorGOsServiceBase;

        void Start()
        {
            _cursorGOsServiceBase = GetComponent<ActionsServiceOnEnableDisableObjectAbstract>();
            _cursorGOsServiceBase.OnDisableObject();
        }
    }
}
