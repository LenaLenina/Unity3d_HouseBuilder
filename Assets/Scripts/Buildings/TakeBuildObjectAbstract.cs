using RayCastHitManager.Abstract;
using UnityEngine;


// 1/3 = 0.3 stable
public abstract class TakeBuildObjectAbstract : RayCastHitManagerServiceAbstract
{
    [SerializeField] protected int _detailId = 0;

    [SerializeField] protected int _restrictCapacity = 5;

    public int DetailId { get => _detailId; }

    public int RestrictCapacity { get => _restrictCapacity; }
}
