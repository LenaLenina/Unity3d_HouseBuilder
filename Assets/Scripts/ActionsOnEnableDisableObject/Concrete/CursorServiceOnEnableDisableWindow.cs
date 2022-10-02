using UnityEngine;
using ActionsOnEnableDisableObject.Abstract;


namespace ActionsOnEnableDisableObject.Concrete
{
    // 2/2 = 1 unstable
    public class CursorServiceOnEnableDisableWindow: ActionsServiceOnEnableDisableObjectAbstract
    {
        public override void OnEnableObject()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }

        public override void OnDisableObject()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
