using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFISH : MonoBehaviour
{
    [SerializeField]
    private AudioClip plopSound;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Player"))
        {

            AudioSource.PlayClipAtPoint(plopSound, transform.position);
            
            Debug.Log("plop");
            
        }
    }

}
