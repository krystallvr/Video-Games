using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    
    //private Rigidbody PlayerBody;
    float playerSpeed;
    public Rigidbody PlayerBody;
    public KeyCode pause, up, down, right, left, cameraLeft, cameraRight;
    public KeyCode up2, down2, right2, left2;
    public GameObject Menu, Inventory;
    public CameraScript view;
	public int baseSpeed;
    public InventoryScript screen;
	public int Level;
	public bool state, controlState, gamePause = false;
  
    void Start()
    {
			AudioListener.pause = false;
			Level = 0;
			GameObject cam = GameObject.Find("Main Camera");
			playerSpeed = baseSpeed;
            up = KeyCode.W;
            down = KeyCode.S;
            left = KeyCode.A;
            right = KeyCode.D;
            up2 = KeyCode.T;
            down2 = KeyCode.G;
            left2 = KeyCode.F;
            right2 = KeyCode.H;
            cameraLeft = KeyCode.LeftArrow;
            cameraRight = KeyCode.RightArrow;
    }
    void KeyboardMovement()
    {
        
        float horizontal = 0;
        float vertical = 0;

        if (controlState == false)
        {

            if (Input.GetKey(up))
            {
                vertical += 1;
            }
            if (Input.GetKey(down))
            {
                vertical -= 1;
            }
            if (Input.GetKey(right))
            {
                horizontal += 1;
            }
            if (Input.GetKey(left))
            {
                horizontal -= 1;
            }
        }
        else
        {
            if (Input.GetKey(up2))
            {
                vertical += 1;
            }
            if (Input.GetKey(down2))
            {
                vertical -= 1;
            }
            if (Input.GetKey(right2))
            {
                horizontal += 1;
            }
            if (Input.GetKey(left2))
            {
                horizontal -= 1;
            }
        }

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        PlayerBody.AddRelativeForce(movement * playerSpeed);

    }
    void  FixedUpdate ()
    {
        if (controlState == false)
           view.MouseAiming();
        else
            view.FixedAiming(cameraLeft, cameraRight);
		
		if (GetComponent<PlayerHealth> ().grounded == true) 
            KeyboardMovement();
	}

    void Update()
    {
		if (!state)
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
        if (gamePause == false)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
			Cursor.lockState = CursorLockMode.None;
            gamePause = !gamePause;
            state = !state;
			AudioListener.pause = state;
            Menu.SetActive(state);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
			Cursor.lockState = CursorLockMode.None;
            gamePause = !gamePause;
            state = !state;
			AudioListener.pause = state;
            Inventory.SetActive(state);

			if (Inventory.activeSelf)
			{
				screen.UpdateInventory ();
			}
        }
    }
    
    public void modifyUp(string upField)
    {
        up = (KeyCode)System.Enum.Parse(typeof(KeyCode), upField);
    }
    public void modifydown(string downField)
    {
        down = (KeyCode)System.Enum.Parse(typeof(KeyCode), downField);
    }
    public void modifyleft(string leftField)
    {
        left = (KeyCode)System.Enum.Parse(typeof(KeyCode), leftField);
    }
    public void modifyright(string rightField)
    {
        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), rightField);
    }
    public void modifyCameraRight(string cameraLeftField)
    {
        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), cameraLeftField);
    }
    public void modifyCameraLEft(string cameraRightField)
    {
        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), cameraRightField);
    }

	void OnCollisionStay(Collision col)
	{
		
		if (col.gameObject.tag == "Ramp") 
		{
			RaycastHit hit;
			var cameraCenter = GameObject.Find ("Main Camera").GetComponent<Camera> ().ScreenToWorldPoint (new Vector3 
				(Screen.width / 2f, Screen.height / 2f, GameObject.Find ("Main Camera").GetComponent<Camera> ().nearClipPlane));
			if(Physics.Raycast(cameraCenter, this.transform.forward, out hit, 1000))
			{
				var obj = hit.transform.gameObject;
				if (obj.tag == "Ramp") 
				{
					playerSpeed = 130;
				}
				if (obj.tag == "Wall") 
				{
					playerSpeed = baseSpeed;
				}
			}
		}
		else
			playerSpeed = baseSpeed;
	}
}
