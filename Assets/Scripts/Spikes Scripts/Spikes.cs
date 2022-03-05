using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip AudioDeath;
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            GameObject.Find("Gameplay Controller").GetComponent<GameplayController>().PlayerDied();
            audioSource.PlayOneShot(AudioDeath);
            Destroy(target.gameObject);
        }
    }
}
