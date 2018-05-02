using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMaster : MonoBehaviour {
    public MovementScript move;
    public GameObject Menu;
    public GameObject ControlsMenu;
	// Use this for initialization
	void Start () 
	{
		move = GameObject.Find ("girl2").GetComponent<MovementScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SwitchIsPressed()
    {
        move.controlState = !move.controlState;
    }

    public void QuitIsPressed()
    {

        Application.Quit();
    }
    public void ControlsIsPressed()
    {
        Menu.SetActive(false);
        ControlsMenu.SetActive(true);
    }
    public void EscapeMenuIsPressed()
    {
        Menu.SetActive(true);
        ControlsMenu.SetActive(false);
    }
	public void StartNewGame()
	{
		move.Level = 1;
		SceneManager.LoadScene (1);
	}
}
