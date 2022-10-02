using Location.Abstract;
using Location.Main;
using UnityEngine;


namespace Location.Concrete
{
    // 3/3 = 1 unstable
    public class LocationController : LocationControllerAbstract
    {
        [SerializeField] private int _currentId;

        [SerializeField] private LocationNode[] _locationNodes;

        [SerializeField] private GameObject _player;

        public override void SetCurrentId(int id)
        {
            _currentId = id;
        }

        public override void GoToNextLocation()
        {
            foreach (var item in _locationNodes)
            {
                if (item._id == _currentId)
                {
                    item._nextLocation.SetActive(true);

                    var p = item._spawnPoint.transform.position;

                    _player.transform.position = new Vector3(p.x, p.y, p.z);

                    item._currentLocation.SetActive(false);
                }
            }
        }
    }
}
