using ActionsOnEnableDisableObject.Abstract;
using UnityEngine.UI;


namespace ActionsOnEnableDisableObject.Concrete
{
    // 1/1 = 1 unstable
    public class TextServiceOnEnableDisableWindow : ActionsServiceOnEnableDisableObjectAbstract
    {
        public Text _text;

        public override void OnEnableObject()
        {
            _text.text = "";
        }

        public override void OnDisableObject()
        {
            _text.gameObject.SetActive(true);
        }
    }
}
