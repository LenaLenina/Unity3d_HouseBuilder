using RayCastHitManager.RayCastHitManagerServices.Abstract;
using UnityEngine;
using DataBase;
using Shared.Abstract;


// 4/4 = 1 unstable
public class TakeBuildObjectPressKey : IExecuteOperationByKeyCodeOnRayEnter
{
    [SerializeField] private TakeBuildObjectAbstract _takeBuildObject;

    [SerializeField] private TextAbstract _detailInfoText;

    public override void OnPressKey()
    {
        if (BuildObjectsDB._buildObjectId == _takeBuildObject.DetailId && BuildObjectsDB._count >= _takeBuildObject.RestrictCapacity) return;

        if(BuildObjectsDB._buildObjectId != _takeBuildObject.DetailId)
        {
            BuildObjectsDB._count = 0;
        }

        BuildObjectsDB._buildObjectId = _takeBuildObject.DetailId;

        BuildObjectsDB._count++;

        _detailInfoText.Write(BuildObjectsDB._count.ToString());

        _takeBuildObject.OnRayEnter();
    }
}
