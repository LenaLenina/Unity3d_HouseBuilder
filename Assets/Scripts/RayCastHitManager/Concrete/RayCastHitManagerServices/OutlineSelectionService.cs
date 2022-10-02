using RayCastHitManager.Abstract;


namespace RayCastHitManager.RayCastHitManagerServices
{
    public class OutlineSelectionService : RayCastHitManagerServiceAbstract
    {
        public override void OnRayEnter()
        {
            SetOutline(true);
        }

        public override void OnRayExit()
        {
            SetOutline(false);
        }

        private void SetOutline(bool value)
        {
            var outline = gameObject.GetComponentInParent<Outline>();

            if (outline == null) return;

            outline.enabled = value;
        }
    }
}
