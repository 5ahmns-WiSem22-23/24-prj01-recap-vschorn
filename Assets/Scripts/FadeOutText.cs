using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutText : MonoBehaviour
{


    [SerializeField] private TextMeshProUGUI text;

    Color color;
    void Start()
    {
        color = text.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (color.a > 0)
        {
            color.a -= Time.deltaTime / 5;
            text.color = color;
        }

    }
}
