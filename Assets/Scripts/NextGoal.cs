using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextGoal : MonoBehaviour {
	LocationLoader load;
	MovementScript move;
	// Use this for initialization
	void Start ()
	{
		load = GameObject.Find ("ScriptHolder").GetComponent<LocationLoader>();
		move = GameObject.Find ("girl2").GetComponent<MovementScript> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		load = GameObject.Find ("ScriptHolder").GetComponent<LocationLoader>();
		move = GameObject.Find ("girl2").GetComponent<MovementScript> ();
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			load.checker = true;
			move.Level = 2;
			SceneManager.LoadScene (3);
		}
	}
}
