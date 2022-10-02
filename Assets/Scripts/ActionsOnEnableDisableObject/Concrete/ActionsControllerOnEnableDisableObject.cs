using ActionsOnEnableDisableObject.Abstract;
using UnityEngine;

namespace ActionsOnEnableDisableObject.Concrete
{
    // 1/1 = 1 unstable
    public class ActionsControllerOnEnableDisableObject : ActionsControllerOnEnableDisableObjectAbstract
    {
        void OnEnable()
        {
            OnEnableObject();
        }

        void OnDisable()
        {
            OnDisableObject();
        }
    }
}
