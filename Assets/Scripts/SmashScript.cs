using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashScript : MonoBehaviour {

	AudioSource sound;
	public AudioClip crash;

	public GameObject cleave;
	public Animator cleaver;
	public Transform demon;
	// Use this for initialization
	void Start()
	{
		sound = gameObject.GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Ground") 
		{
			sound.clip = crash;
			sound.Play();
			Instantiate (cleave, transform.position + transform.forward * transform.localScale.z, 
				Quaternion.Euler(new Vector3(demon.rotation.eulerAngles.x, demon.rotation.eulerAngles.y -90.0f, demon.rotation.eulerAngles.z)));
			cleaver.Play ("Cleave Anim");
			cleaver.Stop ();
		}
		if (col.gameObject.tag == "Floor")
		{
			sound.clip = crash;
			sound.Play();
			Instantiate (cleave, transform.position + transform.forward * transform.localScale.z, 
				Quaternion.Euler(new Vector3(demon.rotation.eulerAngles.x, demon.rotation.eulerAngles.y -90.0f, demon.rotation.eulerAngles.z)));
			cleaver.Play ("Cleave Anim");
			cleaver.Stop ();
		}

	}
}
