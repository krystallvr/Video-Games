using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighteningSpell : MonoBehaviour
{
	public AudioClip lightening;
	AudioSource shock;
	bool playSound;
	int damage, spellSpeed;
    // Use this for initialization

    void Start()
    {
		shock = gameObject.GetComponent<AudioSource> ();
		playSound = true;
        spellSpeed = 100;
        damage = 40;
    }

    // Update is called once per frame
    void Update()
    {
		if (shock.time >= 3.0f) {
			shock.Stop ();
			Destroy (gameObject);
		}
        Behavior();
    }
   
    void OnCollisionEnter(Collision col)
    {
		if (col.gameObject.tag == "Enemy")
		{
			col.gameObject.GetComponent<EnemyHealth>().HurtMethod(damage);
			shock.Stop ();
			Destroy(this.gameObject);
		}
		if (col.gameObject.tag == "Wall")
			Destroy(this.gameObject);
		
		if (col.gameObject.tag == "Ground")
			Destroy(this.gameObject);
    }
    void Behavior()
    {
		shock.clip = lightening;
		if(!shock.isPlaying && playSound == true)
		{
			shock.Play();
			playSound = false;
		}
        transform.position += transform.forward* Time.deltaTime * spellSpeed;
    }
}