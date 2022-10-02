using DataBase;
using RayCastHitManager.RayCastHitManagerServices.Abstract;
using UnityEngine;


// 4/4 = 1 unstable
public class PutBuildObject : IExecuteOperationByKeyCodeOnRayEnter
{
    [SerializeField] private Material _material;

    [SerializeField] private BuildObjectAbstract _buildObjectPlace;

    [SerializeField] private CombinerManager _combinerManager;

    private void Awake()
    {
        _combinerManager = FindObjectOfType<CombinerManager>();
    }

    public override void OnPressKey()
    {
        if (_combinerManager == null) return;

        BuildObjectsDB._count--;

        SetMaterial(_material);

        _buildObjectPlace.OnRayExit();

        if (_combinerManager != null) 
            _combinerManager.AddToReady(_buildObjectPlace.gameObject);

        _buildObjectPlace.SetReady(true);
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
