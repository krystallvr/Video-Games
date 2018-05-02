using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
		AudioListener.pause = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartisPress()
	{
		Debug.Log ("boop");
		SceneManager.LoadScene (1);
	}
}
