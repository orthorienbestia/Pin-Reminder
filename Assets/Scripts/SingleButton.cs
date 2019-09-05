using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SingleButton : MonoBehaviour
{
    private int _counter = 0;
    private Button _button;
    private TextMeshProUGUI numberText;
    private Image image;
    public int Counter { get => _counter;  set { _counter = value; } }
    private void Awake()
    {
        _button = GetComponent<Button>();
        numberText = GetComponentInChildren<TextMeshProUGUI>();
        image = GetComponent<Image>();
    }

    private void Start()
    {
        _button.onClick.AddListener(OnPressed);
        UpdateText();
    }

    private void OnPressed()
    {
        print("OnPressed Called");
        _counter++;
        if (_counter == 10) _counter = 0;

        UpdateText();
    }

    public void UpdateText()
    {
        if (_counter != 0) numberText.text = _counter.ToString();
        else numberText.text = "";

        image.color = Random.ColorHSV(0,1,0,1,0.35f,0.7f);
    }
}
