using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float boostTime = 3f;
    public float currentBoostTime;
    public float boostDelayTime = 0f;
    public float currentBoostDelayTime;
    public bool boosting = false;
    public float time;

    public float baseSpeed = 5f;
    public float speedBoost = 100f;
    public float speed;

    
    void Start()
    {
        currentBoostTime = 0f;
        currentBoostDelayTime = 0f;
        speed = baseSpeed;
    }

    void movePlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !boosting && Time.time > currentBoostDelayTime)
        { 
            currentBoostTime = Time.time + boostTime; 
            boosting = true;
        }

        if ((Time.time > currentBoostTime) && boosting)
        { 
            boosting = false;
            currentBoostDelayTime = Time.time + boostDelayTime;
        }

        if (boosting)
        {
            speed = speedBoost;

        }

        if (!boosting)
        {
            speed = baseSpeed;

        }
    }


    // Update is called once per frame
    void Update()
    {
        time = Time.time; //debug
        movePlayer();
    }
}
