using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punching : MonoBehaviour {

	AudioSource sound;
	public AudioClip punch;
	int damage;
	// Use this for initialization
	void Start () 
	{
		sound = gameObject.GetComponent<AudioSource> ();
		damage = 12;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			sound.clip = punch;
			sound.Play ();
			col.GetComponent<Rigidbody> ().AddForce (col.transform.forward * -1 * 1000);
			col.GetComponent<Rigidbody> ().AddForce (col.transform.up * 400);
			col.GetComponent<PlayerHealth>().knockedBack = true;
			col.GetComponent<PlayerHealth> ().grounded = false;
			col.GetComponent<PlayerHealth>().HurtMethod (damage);
			col.GetComponent<PlayerHealth>().timer = 0;
			col.GetComponent<PlayerHealth> ().HurtMethod (damage);
			col.GetComponent<PlayerHealth> ().targetTime = 10.0f;
		}
	}
}
