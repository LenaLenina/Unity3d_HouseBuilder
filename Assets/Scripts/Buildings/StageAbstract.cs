using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;


public abstract class StageAbstract : MonoBehaviour
{
    [SerializeField] private StageAbstract _nextStage;

    [SerializeField] private List<BuildObjectAbstract> _buildObjectAbstracts;

    [SerializeField] private TextMeshProUGUI[] _texts;

    [SerializeField] private CombinerManager _combinerManager;

    private void Start()
    {
        _buildObjectAbstracts = gameObject.GetComponentsInChildren<BuildObjectAbstract>().ToList();
        _combinerManager = FindObjectOfType<CombinerManager>();
    }

    public void OnReadyEvent()
    {
        var isReadyAll = true;

        foreach (var item in _buildObjectAbstracts)
        {
            if (!item.GetReady())
                isReadyAll = false; 
        }

        if (!isReadyAll) return;

        foreach (var item in _texts)
        {
            item.gameObject.SetActive(true);
        }

        gameObject.SetActive(false);

        if (_nextStage == null) return;

        _combinerManager.SetIsNotReadyMeshCombiner(_nextStage.gameObject.GetComponent<MeshCombiner>());
        _nextStage.gameObject.SetActive(true);
    }
}
