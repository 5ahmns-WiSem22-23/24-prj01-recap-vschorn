using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBox : MonoBehaviour
{
    [SerializeField]
    private AudioClip BoxSound;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Player"))
        {

            AudioSource.PlayClipAtPoint(BoxSound, transform.position);

            Debug.Log("plop");

        }
    }
}
