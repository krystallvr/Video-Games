using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonFour : MonoBehaviour {

	public static SingletonFour thingFour;
	// Use this for initialization
	void Awake () 
	{
		if (thingFour == null) {
			DontDestroyOnLoad (gameObject);
			thingFour = this;
		} else if (thingFour != this) {
			Destroy (gameObject);
		}	

	}
	

}
