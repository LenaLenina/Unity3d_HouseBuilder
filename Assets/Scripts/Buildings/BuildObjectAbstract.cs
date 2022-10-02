using RayCastHitManager.Abstract;
using System.Collections.Generic;
using UnityEngine;


// 1/3 = 0.3 stable
public abstract class BuildObjectAbstract : RayCastHitManagerServiceAbstract
{
    [SerializeField] protected int _detailId = 0;

    [SerializeField] private StageAbstract _stage;

    void Start()
    {
        _stage = gameObject.GetComponentInParent<StageAbstract>();
    }

    protected bool _isReady = false;

    public void SetReady(bool value)
    {
        _isReady = value;
        _stage.OnReadyEvent();
    }

    public bool GetReady()
    {
        return _isReady;
    }
}
