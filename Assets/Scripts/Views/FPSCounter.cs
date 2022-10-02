using UnityEngine;
using TMPro;


namespace Views.Concrete
{
    // 4/4 = 1 unstable
    public class FPSCounter : MonoBehaviour
    {
        public TextMeshProUGUI display_Text;

        // Start is called before the first frame update
        void Awake()
        {
            display_Text = GetComponent<TextMeshProUGUI>();
            Application.targetFrameRate = 60;
        }

        private void Update()
        {
            float current = 0;
            current = Time.frameCount / Time.time;
            var avgFrameRate = (int)current;
            if (display_Text != null)
                display_Text.text = avgFrameRate.ToString() + " FPS";
        }
    }
}
