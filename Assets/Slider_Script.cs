using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Script : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _text;

    void Start()
    {
        _slider.onValueChanged.AddListener((listener) => { _text.text = listener.ToString("0%"); } );
    }
}
