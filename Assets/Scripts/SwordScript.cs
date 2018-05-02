using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {

	public int damage;
	AudioSource sound;
	public AudioClip slash;

	// Use this for initialization
	void Start () 
	{
		sound = gameObject.GetComponent<AudioSource> ();
		damage = 15;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			sound.clip = slash;
			col.GetComponent<PlayerHealth>().HurtMethod (damage);
			sound.Play ();
			col.GetComponent<Rigidbody> ().AddForce (col.transform.forward * -1 * 1000);
		}
	}
}
