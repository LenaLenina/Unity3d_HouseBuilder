using ActionsOnEnableDisableObject.Abstract;
using UnityEngine.UI;


namespace ActionsOnEnableDisableObject.Concrete
{
    // 2/2 = 1 unstable
    public class AimServiceOnEnableDisableWindow : ActionsServiceOnEnableDisableObjectAbstract
    {
        public Image _aim;

        public override void OnEnableObject()
        {
            _aim.gameObject.SetActive(false);
        }

        public override void OnDisableObject()
        {
            _aim.gameObject.SetActive(true);
        }
    }
}