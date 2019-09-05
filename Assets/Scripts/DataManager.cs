using System;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] Transform gridTransform;
    public void SaveData()
    {
        Randomize();
        string numbers = "";
        for (int i = 0; i < gridTransform.childCount; i++)
        {
            var child = gridTransform.GetChild(i);
            SingleButton btn = child.gameObject.GetComponent<SingleButton>();

            numbers += btn.Counter;
        }
        PlayerPrefs.SetString("PIN", numbers);
        PlayerPrefs.Save();
        print($"PIN Saved: {numbers}");
    }

    public void LoadData()
    {
        string saved_pin = PlayerPrefs.GetString("PIN", "");
        if (saved_pin == "") return;
        for (int i = 0; i < gridTransform.childCount; i++)
        {
            var child = gridTransform.GetChild(i);
            SingleButton btn = child.gameObject.GetComponent<SingleButton>();

            btn.Counter = Convert.ToInt32(saved_pin[i].ToString());
            btn.UpdateText();
        }
    }

    private void Randomize()
    {
        for (int i = 0; i < gridTransform.childCount; i++)
        {
            var child = gridTransform.GetChild(i);
            SingleButton btn = child.gameObject.GetComponent<SingleButton>();

            if (btn.Counter != 0) continue;
            btn.Counter = UnityEngine.Random.Range(1, 10);
            btn.UpdateText();
        }
    }

    public void Reset()
    {
        for (int i = 0; i < gridTransform.childCount; i++)
        {
            var child = gridTransform.GetChild(i);
            SingleButton btn = child.gameObject.GetComponent<SingleButton>();

            btn.Counter = 0;
            btn.UpdateText();
        }
    }
}
