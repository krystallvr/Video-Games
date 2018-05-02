using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour {

	public LocationLoader load;
	public MovementScript move;
	//public int  position = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			load.checker = true;
			move.Level = 1;
			SceneManager.LoadScene (2);
		}
	}
}
