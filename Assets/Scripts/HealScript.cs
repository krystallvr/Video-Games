using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealScript : MonoBehaviour {
	public PlayerHealth health;
	AudioSource heal;
	public AudioClip healsound;

	// Use this for initialization
	void Start () 
	{
		heal = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (heal.time >= 3.0f) 
		{
			heal.Stop ();
			Destroy (gameObject);
		}
		Behavior ();
	}
	void Behavior()
	{
		heal.clip = healsound; 

		if(!heal.isPlaying)
		{
			heal.Play ();
		}
	}
}
