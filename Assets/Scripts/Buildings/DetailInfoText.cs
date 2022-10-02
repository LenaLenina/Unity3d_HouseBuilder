using Shared.Abstract;
using TMPro;
using UnityEngine;


// 2/2 = 1 unstable
public class DetailInfoText : TextAbstract
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GameObject.Find("DetailInfoText").GetComponent<TextMeshProUGUI>();
    }

    public override void Write(string message)
    {
        if(_text != null)
            _text.text = message;
    }

    public override void Clear()
    {
        if (_text != null)
            _text.text = "";
    }
}
