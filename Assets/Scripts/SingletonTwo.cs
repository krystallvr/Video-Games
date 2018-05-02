using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTwo : MonoBehaviour {

	public static SingletonTwo thingTwo;
	// Use this for initialization
	void Awake () 
	{
		if (thingTwo == null) {
			DontDestroyOnLoad (gameObject);
			thingTwo = this;
		} else if (thingTwo != this) {
			Destroy (gameObject);
		}	

	}
	

}
