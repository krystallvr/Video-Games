using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public float turnspeed = 50f;
    public KeyCode cameraLeft, cameraRight;
    public GameObject player;

	public void MouseAiming ()
    {
        Vector3 rot = new Vector3(0f, 0f, 0f);

        //Rotates the camera up with the movement of the mouse
        if (Input.GetAxis("Mouse Y") < 0 )
        {
			
			if (transform.rotation.x < 100 / 360f)
				rot.x += 1;
        }
        //Rotates the camera down with the movement of the mouse
        if (Input.GetAxis("Mouse Y") > 0 )
        {
			if(transform.rotation.x > -100 / 360f)
				rot.x -= 1;
			
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            rot.y -= 1.5f;
        }
        //Rotates the camera right with the movement of the mouse
        if (Input.GetAxis("Mouse X") > 0)
        {
            rot.y += 1.5f;
        }

		player.transform.Rotate(new Vector3(0.0f, rot.y, 0.0f)  * turnspeed * Time.deltaTime);
		transform.Rotate(new Vector3(rot.x, 0.0f, 0.0f) * turnspeed * Time.deltaTime); 

		//transform.rotation = Quaternion.Euler(transform.rotation.x, tempX, 0.0f);
    }
    public void FixedAiming(KeyCode left, KeyCode right)
    {
        Vector3 rot = new Vector3(0f, 0f, 0f);

        if (Input.GetKey(left))
        {
            rot.y -= 1;
        }
        //Rotates the camera right with the movement of the keys
        if (Input.GetKey(right))
        {
            rot.y += 1;
        }

        player.transform.localEulerAngles += rot * turnspeed * Time.deltaTime;
    }
    // Use this for initialization
    void Start ()
    {
		//Cursor.lockState = CursorLockMode.Locked;
        cameraLeft = KeyCode.LeftArrow;
        cameraRight = KeyCode.RightArrow;
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update ()
    {
		
    }
}
