using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaveScirpt : MonoBehaviour {
	public int damage;

	//public PlayerHealth health;
	// Use this for initialization
	void Awake () {
		damage = 50;
		Destroy (transform.parent.gameObject, 1f);
		//Destroy (gameObject, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
			col.gameObject.GetComponent<PlayerHealth> ().HurtMethod (damage);
		}
	}
}
