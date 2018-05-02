using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
	GameObject player;

	Vector3 destination;
	float distance;
	float doorRotate;
	bool playSound = false;
	public AudioSource open, close;
	// Use this for initialization

	void Start () 
	{
		player = GameObject.Find("girl2");
	}
	
	// Update is called once per frame
	void Update () {
		destination = player.transform.position;
		distance = Vector3.Distance (gameObject.transform.position, destination);

		if (distance < 25) {
			if (gameObject.transform.eulerAngles.y < 90 || gameObject.transform.eulerAngles.y > 350) 
			{
				playSound = true;
				Debug.Log ("Opening");
				gameObject.transform.Rotate (new Vector3 (0, 4, 0) * Time.deltaTime * 9);
				if (playSound == true && !open.isPlaying) {
					open.Play ();
				}
			} 

			else if(gameObject.transform.eulerAngles.y >= 90)
			{
				Debug.Log ("Stop");
			}
		} 
		else 
		{
			if (gameObject.transform.eulerAngles.y > 0) {
				playSound = true;
					Debug.Log ("Closing");
					gameObject.transform.Rotate (new Vector3 (0, -4, 0) * Time.deltaTime * 9);
				if (gameObject.transform.rotation.y < 0)
					transform.rotation = new Quaternion (transform.rotation.x, 0.0f, transform.rotation.z, transform.rotation.w);
				if (playSound == true && !close.isPlaying) {
					close.Play ();
				}
			} 
			else
			{
				//Debug.Log ("Closed");
			}
		}
	}
}
