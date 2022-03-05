using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
	public AudioSource audioSource;
	public AudioClip AudioCollect;
	void Start()
	{
		if (Door.instance != null)
		{
			Door.instance.collectablesCount++;
		}
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			audioSource.PlayOneShot(AudioCollect);
			if (Door.instance != null)
			{
				Door.instance.DecrementCollectables();
			}
		}
	}
	// Update is called once per frame
	void Update()
	{

	}
}
