using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonOne : MonoBehaviour {

	public static SingletonOne thingOne;
	// Use this for initialization
	void Awake () 
	{
		if (thingOne == null) {
			DontDestroyOnLoad (gameObject);
			thingOne = this;
		} else if (thingOne != this) {
			Destroy (gameObject);
		}	

	}
	

}
