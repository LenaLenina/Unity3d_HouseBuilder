using UnityEngine;
using RayCastHitManager.Abstract;


namespace RayCastHitManager.RayCastHitManagerServices
{
    public abstract class ExecuteOperationByKeyCodeOnRayEnterBase : RayCastHitManagerServiceAbstract
    {
        private bool _onRayEnter = false;

#if UNITY_EDITOR
        [SerializeField] private HBActions _input;
#endif
        private void Awake()
        {
#if UNITY_EDITOR
            _input = new HBActions();

            _input.Player.Interact.performed += context =>
            {
                if (_onRayEnter) OnPressKey();
            };

            _input.Enable();
#endif

            InteractButtonEvent.onPressButton += () => {
                if (_onRayEnter) OnPressKey();
            };
        }

        public override void OnRayEnter()
        {
            _onRayEnter = true;
        }

        public override void OnRayExit()
        {
            _onRayEnter = false;
        }

        
        protected abstract void OnPressKey(); 
    }
}
