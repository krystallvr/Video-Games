using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour {
	public InventoryScript inv;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ClickedBoxOn1()
	{
		inv.active1 = true;
	}
	public void ClickedBoxOn2()
	{
		inv.active2 = true;
	}
	public void ClickedBoxOn3()
	{
		inv.active3 = true;
	}
	public void ClickedBoxOn4()
	{
		inv.active4 = true;
	}
	public void ClickedBoxOn5()
	{
		inv.active5 = true;
	}
	public void ClickedBoxOn6()
	{
		inv.active6 = true;
	}
}
