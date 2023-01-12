using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{



    [SerializeField] private SpriteRenderer Line;
   
    Color color;
    void Start()
    {
        color = Line.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (color.a > 0)
        {
            color.a -= Time.deltaTime / 5;
            Line.color = color;
        }

    }

}
