using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationLoader : MonoBehaviour {
	public MovementScript move;
	public Transform player;
	public bool checker = true;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(checker == true)
		{
			if (move.Level == 0) {
				player.transform.position = GameObject.Find ("Start Location").transform.position;
				checker = false;
			} else if (move.Level == 1) {
				player.transform.position = GameObject.Find ("Start Location Two").transform.position;
                player.transform.rotation = GameObject.Find("Start Location Two").transform.rotation;
				checker = false;
			} else if (move.Level == 2) {
				player.transform.position = GameObject.Find ("Start Location Three").transform.position;
				checker = false;
			}
		}
	}
}
