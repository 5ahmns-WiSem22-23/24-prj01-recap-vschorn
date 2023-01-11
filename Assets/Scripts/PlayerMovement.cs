using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public float boostTime = 1.5f;
    public float currentBoostTime;
    public float boostDelayTime = 0f;
    public float currentBoostDelayTime;
    public bool boosting = false;
    public float time;


    public float speedBoost = 15f;
    public float speed;


    void Start()
    {
        currentBoostTime = 0f;
        currentBoostDelayTime = 0f;
        speed = moveSpeed;
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

        if (boosting == true)
        {
            speed = 5000f;

        }

        if (!boosting)
        {
            speed = moveSpeed;

        }
    }


    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        time = Time.time; //debug
        movePlayer();
    }


    public void FixedUpdate()
    {
        //Movement



        rb.MovePosition(rb.position + movement * moveSpeed  * Time.fixedDeltaTime);

       if (boosting == true)
        {
            moveSpeed = 10f;
        }

        if (boosting == false)
        {
            moveSpeed = 5f;

        }

    }

   




}
