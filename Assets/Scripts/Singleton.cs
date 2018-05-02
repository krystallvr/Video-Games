using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {

	public static Singleton thing;
	// Use this for initialization
	void Awake () 
	{
		if (thing == null) {
			DontDestroyOnLoad (gameObject);
			thing = this;
		} else if (thing != this) {
			Destroy (gameObject);
		}	

	}
	

}
