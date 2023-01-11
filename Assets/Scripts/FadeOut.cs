using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{



    [SerializeField] private TextMeshProUGUI InfoText;
   
    Color color;
    void Start()
    {
        color = InfoText.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (color.a > 0)
        {
            color.a -= Time.deltaTime;
            InfoText.color = color;
        }

    }

}
