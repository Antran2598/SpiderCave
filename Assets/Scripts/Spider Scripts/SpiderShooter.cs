using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    public AudioSource audioSource;
    public AudioClip AudioDeath;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(Random.Range(1, 3));
        Instantiate(bullet, transform.position, Quaternion.identity);
        StartCoroutine(Attack());
    }

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
