using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : MonoBehaviour
{
	public AudioClip ice;
	public AudioClip crash;
	bool playSound;
	int spellSpeed, damage;
	AudioSource playSoundThing;
	//public AudioSource play;

        // Use this for initialization

        void Start()
        {
		playSoundThing = gameObject.GetComponent<AudioSource> ();
			playSound = true;
            spellSpeed = 10;
            damage = 50;
        }

        // Update is called once per frame
        void Update()
        {
		Destroy (gameObject, 6);
		Behavior ();
        }

        void OnCollisionEnter(Collision col)
        {
			playSoundThing.clip = crash;
			if (col.gameObject.tag == "Enemy")
			{
				col.gameObject.GetComponent<EnemyHealth>().HurtMethod(damage);
				playSoundThing.Play ();
				Destroy (this.gameObject.GetComponent<Collider> ());
				Destroy(this.gameObject, crash.length);
			}
		else if (col.gameObject.tag == "Wall") 
		{
			playSoundThing.Play ();
			Destroy (this.gameObject.GetComponent<Collider> ());
			Destroy (this.gameObject, crash.length);
		}
		else if(col.gameObject.tag == "Ground")
		{
			playSoundThing.Play ();
			Destroy (this.gameObject.GetComponent<Collider> ());
			Destroy (this.gameObject, crash.length);
		}
       		 }
	void Behavior()
	{
		if(!playSoundThing.isPlaying && playSound == true)
		{
			playSoundThing.clip = ice;
			playSoundThing.Play ();
			playSound = false;
		}
		transform.position += transform.forward * Time.deltaTime * spellSpeed;
        	
        }
}

