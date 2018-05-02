using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealSpell : MonoBehaviour {

	public PlayerHealth health;
	AudioSource heal;
	public AudioClip thing;
	// Use this for initialization
	void Start () 
	{
		heal = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (heal.time >= 5.0f) 
		{
			heal.Stop ();
			Destroy (gameObject);
		}
		Behavior ();
	}
	void Behavior()
	{
		heal.clip = thing;
		if(!heal.isPlaying)
		{
			heal.Play ();
		}
	}
}
