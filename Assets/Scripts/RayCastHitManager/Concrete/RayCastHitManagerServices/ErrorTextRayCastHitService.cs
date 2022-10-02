using UnityEngine;
using RayCastHitManager.Abstract;
using TMPro;


namespace RayCastHitManager.RayCastHitManagerServices
{
    public class ErrorTextRayCastHitService : RayCastHitManagerServiceAbstract
    {
        [SerializeField] private TextMeshProUGUI _errorText;

        [SerializeField] private string _message = "Attention";

        private void Start()
        {
            _errorText = GameObject.Find("ErrorText").GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            if (_errorText == null)
                _errorText = GameObject.Find("ErrorText").GetComponent<TextMeshProUGUI>();
        }

        public override void OnRayEnter()
        {
            if (_errorText == null) return;

            _errorText.gameObject.SetActive(true);
            _errorText.text = _message;
        }

        public override void OnRayExit()
        {
            if (_errorText == null) return;

            _errorText.text = "";
            _errorText.gameObject.SetActive(false);
        }
    }
}
