using DataBase;
using RayCastHitManager.Abstract;
using Shared.Abstract;
using UnityEngine;


// 4/4 = 1 unstable
public class TakeBuildObject : TakeBuildObjectAbstract
{
    [SerializeField] private RayCastHitManagerServiceAbstract _goodConditions;

    [SerializeField] private RayCastHitManagerServiceAbstract _badConditions;

    [SerializeField] private TextAbstract _detailInfoText;

    public override void OnRayEnter()
    {
        var count = BuildObjectsDB._buildObjectId == _detailId ? BuildObjectsDB._count : 0;

        _detailInfoText.Write($"Detail Id: {_detailId} - Count: { count }" );

        if (BuildObjectsDB._buildObjectId == _detailId && BuildObjectsDB._count >= _restrictCapacity)
        {
            _badConditions.OnRayEnter();

            return;
        }

        _goodConditions.OnRayEnter();
    }

    public override void OnRayExit()
    {
        _detailInfoText.Clear();
        _goodConditions.OnRayExit();
        _badConditions.OnRayExit();
    }
}
