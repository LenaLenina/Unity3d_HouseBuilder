using Location.Abstract;
using UnityEngine;
using UnityEngine.UI;
using Views.Abstract;


namespace Views.Concrete
{
    // 3/3 = 1 unstable
    public class GoToNextLocationView : View
    {
        [SerializeField] private Button _button;

        [SerializeField] private LocationControllerAbstract _locationController;

        void Start()
        {
            _button = GetComponent<Button>();

            _locationController = FindObjectOfType<LocationControllerAbstract>();

            AddEventListeners();
        }

        private void AddEventListeners()
        {
            _button.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            _locationController.GoToNextLocation();
            gameObject.SetActive(false);
        }
    }
}
