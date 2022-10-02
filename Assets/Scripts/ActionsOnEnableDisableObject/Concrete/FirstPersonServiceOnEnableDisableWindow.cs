using ActionsOnEnableDisableObject.Abstract;


namespace ActionsOnEnableDisableObject.Concrete
{
    // 1/1 = 1 unstable
    public class FirstPersonServiceOnEnableDisableWindow : ActionsServiceOnEnableDisableObjectAbstract
    {
        //public BBS.Person.FirstPersonController _firstPersonController;

        public override void OnEnableObject()
        {
            //_firstPersonController.enabled = false;
        }

        public override void OnDisableObject()
        {
            //_firstPersonController.enabled = true;
        }
    }
}
