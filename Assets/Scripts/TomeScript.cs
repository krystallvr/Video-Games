//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class TomeScript : MonoBehaviour {
//
//	public Spell fire, ice, lightening, healPartial, heal, healHalf;
//	public GameObject fireObj, iceObj, lightObj, healObj, partialHealObj, halfHealObj;
//	public Transform tome;
//	public MovementScript move;
//	public InventoryScript inven;
//	public Text amtTxt;
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//		//if (Input.GetButtonDown ("Fire1")&& move.state!= true) 
//		//{
//			
//			//Use ();
//		//}
//	}
//	int returnIndex(string name)
//	{
//		for (int i = 0; i < inven.items.Count; i++)
//		{
//			if (inven.items [i].name == name)
//				return i;
//		}
//	}
//	void Use(string name)
//	{
//		int index = 0;
//		switch (name) 
//		{
//		case("Fire"):
//			if(fire.SpellCount() > 0)
//			{
//				Instantiate (fireObj, tome.position, Quaternion.identity);
//				fire.SubtractSpellAmount ();
//				if(fire.SpellCount() == 0)
//				{
//					inven.items.Remove (inven.quickItems [inven.currentBox]);
//					inven.quickItems [inven.currentBox] = null;
//					inven.UpdateQuickbar();
//				}
//			}
//			break;
//		case("Lightening"):
//			if(lightening.SpellCount() > 0)
//			{
//				Instantiate (lightObj, tome.position, Quaternion.identity);
//				lightening.SubtractSpellAmount ();
//				if(lightening.SpellAmount() == 0)
//				{
//					inven.items.Remove (inven.quickItems [inven.currentBox]);
//					inven.quickItems [inven.currentBox] = null;
//					inven.UpdateQuickbar();
//				}
//			}
//			break;
//		case("Ice"):
//			if(ice.SpellCount() > 0)
//			{
//				Instantiate (iceObj, tome.position, Quaternion.identity);
//				ice.SubtractSpellAmount ();
//				if(ice.SpellCount() == 0)
//				{
//					inven.items.Remove (inven.quickItems [inven.currentBox]);
//					inven.quickItems [inven.currentBox] = null;
//					inven.UpdateQuickbar();
//				}
//			}
//			break;
//		case("Heal"):
//			if(heal.SpellCount() > 0)
//			{
//				Instantiate (healObj, tome.position, Quaternion.identity);
//				heal.SubtractSpellAmount ();
//				amtTxt = inven.inventoryPanel.Find ("Quantity " + (inven.items.Count)).GetComponent<Text> ();
//				amtTxt.text = heal.SpellCount().ToString ();
//				if(heal.SpellCount() == 0)
//				{
//					inven.items.Remove (inven.quickItems [inven.currentBox]);
//					inven.quickItems [inven.currentBox] = null;
//					inven.UpdateQuickbar();
//				}
//			}
//			break;
//		case("Partial Heal"):
//			if (healPartial.SpellCount () > 0) {
//				Instantiate (partialHealObj, tome.position, Quaternion.identity);
//				healPartial.SubtractSpellAmount ();
//				index = returnIndex (inven.quickItems [inven.currentBox].name);
//				amtTxt = inven.inventoryPanel.Find ("Quantity " + (inven.items.Count)).GetComponent<Text> ();
//				amtTxt.text = healPartial.SpellCount().ToString ();
//				if(healPartial.SpellCount() ==0)
//				{
//					inven.items.Remove (inven.quickItems [inven.currentBox]);
//					inven.quickItems [inven.currentBox] = null;
//					inven.UpdateQuickbar();
//				}
//			}
//			break;
//		case("Half Heal"):
//			if(healHalf.SpellCount() > 0)
//			{
//				Instantiate (halfHealObj, tome.position, Quaternion.identity);
//				healHalf.SubtractSpellAmount ();
//				index = returnIndex (inven.quickItems [inven.currentBox].name);
//				amtTxt = inven.inventoryPanel.Find ("Quantity " + (inven.items.Count)).GetComponent<Text> ();
//				amtTxt.text = healHalf.SpellCount().ToString ();
//				if (healHalf.SpellCount () == 0)
//				{
//					inven.items.Remove (inven.quickItems [inven.currentBox]);
//					inven.quickItems [inven.currentBox] = null;
//					inven.UpdateQuickbar();
//				}
//			}
//			break;
//
//		default:
//			break;
//		}
//	}
//}
