using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpin : MonoBehaviour {

    public float floatStrength, speed;
	public Transform tome;
	public int value;
	public MovementScript move;
	//bool tomeState = false;
	//float rate = 1.0f;
	//float tomeHeightMax = 10;
	//float tomeHeightMin = 9;
	Vector3 tempPos;
	public float originalY;

    // Use this for initialization
    void Start()
    {
		originalY = tome.position.y;
    }

    // Update is called once per frame
    void Update()
    {	
		if (!move.state && this.enabled == true) {
			originalY = tome.position.y;
			tempPos.y = originalY + floatStrength * Mathf.Sin (speed * Time.time);
			tempPos.z = tome.position.z;
			tempPos.x = tome.position.x;
			transform.position = tempPos;	
		}
    }
//	void spin()
//	{
//		if (tomeState) 
//			gameObject.transform.position += new Vector3(0, Time.deltaTime * rate,0);
//		else
//			gameObject.transform.position += new Vector3(0, Time.deltaTime * -rate,0);
//		if (gameObject.transform.position.y >= tomeHeightMax || gameObject.transform.position.y <= tomeHeightMin)
//			tomeState = !tomeState;
//	}
}
