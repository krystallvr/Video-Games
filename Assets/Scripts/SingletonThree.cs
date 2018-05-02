using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonThree : MonoBehaviour {

	public static SingletonThree thingThree;
	// Use this for initialization
	void Awake () 
	{
		if (thingThree == null) {
			DontDestroyOnLoad (gameObject);
			thingThree = this;
		} else if (thingThree != this) {
			Destroy (gameObject);
		}	

	}
	

}
