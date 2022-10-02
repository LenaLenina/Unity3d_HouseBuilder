using System;
using UnityEngine;
using UnityEngine.UI;

// 0/2 = 0 stable
public class InteractButtonEvent
{
    public static Action onPressButton;
}

// 2/2 = 1 unstable
public class InteractButton : MonoBehaviour
{
    public Button _button;

    void Start()
    {
        _button.onClick.AddListener(() => { 
            InteractButtonEvent.onPressButton?.Invoke();
        });
    }
}
