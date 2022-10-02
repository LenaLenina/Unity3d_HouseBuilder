using DataBase;
using RayCastHitManager.Abstract;
using Shared.Abstract;
using UnityEngine;


// 5/5 = 1 unstable
public class BuildObjectPlace : BuildObjectAbstract
{
    [SerializeField] private RayCastHitManagerServiceAbstract _goodConditions;

    [SerializeField] private RayCastHitManagerServiceAbstract _badConditions;

    [SerializeField] private TextAbstract _detailInfoText;

    public override void OnRayEnter()
    {
        if (_isReady) return;

        _detailInfoText.Write("Detail id: " + _detailId);

        if (BuildObjectsDB._buildObjectId != _detailId || BuildObjectsDB._count < 1)
        {
            _badConditions.OnRayEnter();

            return;
        }

        _goodConditions.OnRayEnter();
    }

    public override void OnRayExit()
    {
        if (_isReady) return;

        _detailInfoText.Clear();
        _badConditions.OnRayExit();
        _goodConditions.OnRayExit();
    }
}
