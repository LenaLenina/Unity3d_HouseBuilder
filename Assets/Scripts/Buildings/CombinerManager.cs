using UnityEngine;


// 4/5 = 0.8 stable
public class CombinerManager : MonoBehaviour
{
    [SerializeField] private GameObject _isReadyChunk;

    [SerializeField] private GameObject _isNotReadyChunk;

    [SerializeField] private MeshCombiner _isReadyCombiner;

    [SerializeField] private MeshCombiner _isNotReadyCombiner;

    public void AddToReady(GameObject gameObject)
    {
        gameObject.transform.SetParent(_isReadyChunk.transform);

        Combine(_isNotReadyCombiner);
        Combine(_isReadyCombiner);
    }

    private void Combine(MeshCombiner meshCombiner)
    {
        meshCombiner.CreateMultiMaterialMesh = true;
        meshCombiner.DeactivateCombinedChildrenMeshRenderers = true;

        meshCombiner.CombineMeshes(false);
    }

    public void SetIsNotReadyMeshCombiner(MeshCombiner isNotReadyCombiner)
    {
        _isNotReadyCombiner = isNotReadyCombiner;
    }
}
