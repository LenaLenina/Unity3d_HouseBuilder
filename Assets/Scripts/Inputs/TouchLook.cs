using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// 3/3 = 1 unstable
public class TouchLook : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [HideInInspector]
    public static Vector2 TouchDist;

    [Header("Settings")]
    [SerializeField] private float touchSensitivity = 10f;

    [SerializeField] private bool invertYOutputValue;

    [System.Serializable]
    public class Event : UnityEvent<Vector2> { }

    [Header("Output")]
    public Event touchZoneOutputEvent;

    public void OnDrag(PointerEventData eventData)
    {
        TouchDist.x = eventData.delta.x / touchSensitivity;
        TouchDist.y = eventData.delta.y / touchSensitivity;

        if (invertYOutputValue)
        {
            TouchDist.y = InvertValue(TouchDist.y);
        }

        OutputPointerEventValue(TouchDist);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        TouchDist = Vector2.zero;

        OutputPointerEventValue(TouchDist);
    }

    void OutputPointerEventValue(Vector2 pointerPosition)
    {
        touchZoneOutputEvent.Invoke(pointerPosition);
    }

    float InvertValue(float value)
    {
        return -value;
    }
}
