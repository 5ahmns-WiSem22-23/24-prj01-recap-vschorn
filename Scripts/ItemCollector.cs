using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class ItemCollector : MonoBehaviour
{
    private int FishCount = 0;
    public GameObject Box;
    public GameObject FISH;
    public GameObject FISH1;
    public GameObject FISH2;
    public GameObject FISH3;
    public GameObject FISH4;
    private int FishInsgesamt = 0;






    [SerializeField] private TextMeshProUGUI FishText;
    [SerializeField] private TextMeshProUGUI Fishinsgesamt;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            FISH.SetActive(false);
            FISH1.SetActive(false);
            FISH2.SetActive(false);
            FISH3.SetActive(false);
            FISH4.SetActive(false);




            FishCount++;
            FishInsgesamt++;
            FishText.text = "Fish Counter: 1 / 1";
            Fishinsgesamt.text = "Fish collected: 1 / 5"; 
        }

        if (collision.gameObject.CompareTag("Box"))
        {

            FishText.text = "Fish Counter: 0 / 1";
            Debug.Log("collide");
            


        }

        if (collision.gameObject.CompareTag("Box"))
        {
            FISH.SetActive(false);
            FISH1.SetActive(true);
            

        }

        if (collision.gameObject.CompareTag("Collectible1"))
        {
            Destroy(FISH);
            FISH1.SetActive(true);
            FishText.text = "Fish Counter: 1 / 1";
            Fishinsgesamt.text = "Fish collected: 2 / 5";

        }

        if (collision.gameObject.CompareTag("Collectible1"))
        {
            Destroy(FISH1);
            FISH2.SetActive(true);

        }

        if (collision.gameObject.CompareTag("Collectible2"))
        {
            Destroy(FISH2);
            FISH3.SetActive(true);
            FishText.text = "Fish Counter: 1 / 1";
            Fishinsgesamt.text = "Fish collected: 3 / 5";

        }

        if (collision.gameObject.CompareTag("Collectible3"))
        {
            Destroy(FISH3);
            FISH4.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Collectible3"))
        {
            Destroy(FISH3);
            FISH4.SetActive(true);
            FishText.text = "Fish Counter: 1 / 1";
            Fishinsgesamt.text = "Fish collected: 4 / 5";

        }
        if (collision.gameObject.CompareTag("Collectible4"))
        {
            Destroy(FISH4);
            FishText.text = "Fish Counter: 1 / 1";
            Fishinsgesamt.text = "Fish collected: 5 / 5";
        }

      


    }

   
    
    }