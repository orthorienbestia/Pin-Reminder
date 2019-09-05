using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TempScript : MonoBehaviour
{
    [ContextMenu("Do Something")]
    void DoSomething()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            var btn = child.gameObject.GetComponent<Image>();

            var t= btn.GetComponentInChildren<TextMeshProUGUI>();
            t.fontStyle = FontStyles.Bold;
        }
    }
}
