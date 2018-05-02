using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotator : MonoBehaviour {
    
    public float floatStrength = 1;
    
    float originalY;
    
	// Use this for initialization
	void Start ()
    {
        this.originalY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(transform.position.x,
        originalY + (((float)Mathf.Sin(Time.time) * floatStrength)), transform.position.z);
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
