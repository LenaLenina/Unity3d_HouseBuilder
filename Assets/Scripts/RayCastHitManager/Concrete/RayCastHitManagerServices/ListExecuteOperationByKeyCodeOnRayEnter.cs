using RayCastHitManager.RayCastHitManagerServices.Abstract;

namespace RayCastHitManager.RayCastHitManagerServices
{
    public class ListExecuteOperationByKeyCodeOnRayEnter : ExecuteOperationByKeyCodeOnRayEnterBase
    {
        private IExecuteOperationByKeyCodeOnRayEnter[] _operation;

        void Start()
        {
            _operation = GetComponents<IExecuteOperationByKeyCodeOnRayEnter>();
        }

        protected override void OnPressKey()
        {
            if (_operation == null) return;

            foreach (var item in _operation)
            {
                item.OnPressKey();
            }
        }
    }
}
