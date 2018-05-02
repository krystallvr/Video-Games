using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGoal : MonoBehaviour {

    GameObject menu, gui;
	// Use this for initialization
	void Start ()
    {
        menu = GameObject.Find("Menu System");
        gui = GameObject.Find("Player GUI");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			SceneManager.LoadScene (4);
            Destroy(col.gameObject);
            Destroy(menu);
            Destroy(gui);
            Cursor.lockState = CursorLockMode.None;
        }
	}
}
