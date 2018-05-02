using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : MonoBehaviour
{
	AudioSource fire;
	public AudioClip fireSound, fireSoundTwo;
	int damage, spellSpeed;
	bool firePlay = false;

	void Start ()
    {
		firePlay = true;
		spellSpeed = 40;
        damage = 70;
		fire = gameObject.GetComponent<AudioSource> ();
    }
	void Update()
	{
		Destroy (gameObject, 3);
		Behavior ();
	}
	void Behavior()
	{
		if(!fire.isPlaying && firePlay == true)
		{
			fire.clip = fireSound;
			fire.Play ();
			firePlay = false;
		}
		transform.position += transform.forward * Time.deltaTime * spellSpeed;
	}

    void OnCollisionEnter(Collision col)
    {
		fire.clip = fireSoundTwo;
		if (col.gameObject.tag == "Enemy") {
			
			col.gameObject.GetComponent<EnemyHealth> ().HurtMethod (damage);
			fire.Play ();
			Destroy (this.gameObject.GetComponent<Collider>());
			Destroy (this.gameObject, fireSoundTwo.length);
		}
		else if (col.gameObject.tag == "Wall")
		{
			fire.Play ();
			Destroy (this.gameObject.GetComponent<Collider> ());
			Destroy (this.gameObject, fireSoundTwo.length);
		}
		else  if(col.gameObject.tag == "Ground") 
		{
			fire.Play ();
			Destroy (this.gameObject.GetComponent<Collider> ());
			Destroy (this.gameObject, fireSoundTwo.length);
		}
    }
}
