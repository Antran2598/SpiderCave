using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBullet : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip AudioDeath;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            GameObject.Find("Gameplay Controller").GetComponent<GameplayController>().PlayerDied();
            audioSource.PlayOneShot(AudioDeath);
            Destroy(target.gameObject);
            Destroy(gameObject);
        }
        if(target.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
