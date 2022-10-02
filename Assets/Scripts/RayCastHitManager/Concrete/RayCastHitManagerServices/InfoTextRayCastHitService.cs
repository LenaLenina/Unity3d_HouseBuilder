using UnityEngine;
using RayCastHitManager.Abstract;
using TMPro;


namespace RayCastHitManager.RayCastHitManagerServices
{
    public class InfoTextRayCastHitService : RayCastHitManagerServiceAbstract
    {
        [SerializeField] private TextMeshProUGUI _infoText;

        [SerializeField] private string _message = "Press F";

        private void Start()
        {
            _infoText = GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            if (_infoText == null)
                _infoText = GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>();
        }

        public override void OnRayEnter()
        {
            if (_infoText == null) return;

            _infoText.gameObject.SetActive(true);
            _infoText.text = _message;
        }

        public override void OnRayExit()
        {
            if (_infoText == null) return;

            _infoText.text = "";
            _infoText.gameObject.SetActive(false);
        }
    }
}
