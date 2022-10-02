using UnityEngine;
using RayCastHitManager.Abstract;


namespace RayCastHitManager.RayCastHitManagerServices
{
    public class MaterialSelectionService : RayCastHitManagerServiceAbstract
    {
        [SerializeField] private Material highlightMaterial;
        [SerializeField] private Material defaultMaterial;

        public override void OnRayEnter()
        {
            SetMaterial(highlightMaterial);
        }

        public override void OnRayExit()
        {
            SetMaterial(defaultMaterial);
        }

        private void SetMaterial(Material newMaterial)
        {
            var selectionRenderer = gameObject.transform.GetComponentInParent<Renderer>();

            if (selectionRenderer != null)
            {
                selectionRenderer.material = newMaterial;
            }
        }
    }
}
