using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryScript : MonoBehaviour {

	public PlayerHealth pHealth; 
	public Transform player;
    private int itemNum;
    public int currentItem, currentBox;
    public List<GameObject> items;
	public GameObject[] Selectors;
    public List<GameObject> quickItems;
	public Transform inventoryPanel, tome;
	public FireCount fire;
	public HalfHealCount healHalf;
	public IceCount ice;
	public LighteningCount lightening;
	public HealCount heal;
	public PartialHealCount healPartial;
	public MovementScript move;
	public Image tempSpace1;
	public Text amtText, ammoTxt;
	public bool active1, active2, active3, active4, active5, active6;
	public GameObject fireObj, iceObj, lightObj, healObj, partialHealObj, halfHealObj, tomeObj;
	public GameObject inventory, quickbar;

    // Use this for initialization

    void Start ()
    {
		
	}
	// Update is called once per frame
	void Update ()
	{
		QuickItemsCycler ();
		Setter ();

		if (Input.GetButtonDown ("Fire1") && move.state != true && tomeObj.activeSelf) {
			Use ();
		}
	}

	void QuickItemsCycler()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Selectors [0].SetActive (true);
			Selectors [1].SetActive (false);
			Selectors [2].SetActive (false);
			Selectors [3].SetActive (false);
			Selectors [4].SetActive (false);
			currentBox = 0;

            if (quickItems[0] != null)
            {
                if (quickItems[0].name == "Fireball")
                {
                    ammoTxt.text = fire.SpellCount().ToString();
                }
                else if (quickItems[0].name == "Ice Spell")
                {
                    ammoTxt.text = ice.SpellCount().ToString();
                }
                else if (quickItems[0].name == "Lightening Spell")
                {
                    ammoTxt.text = lightening.SpellCount().ToString();
                }
                else if (quickItems[0].name == "Heal Spell")
                {
                    ammoTxt.text = heal.SpellCount().ToString();
                }
                else if (quickItems[0].name == "Partial Heal Spell")
                {
                    ammoTxt.text = healPartial.SpellCount().ToString();
                }
                else
                {
                    ammoTxt.text = healHalf.SpellCount().ToString();
                }
            }
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Selectors [0].SetActive (false);
			Selectors [1].SetActive (true);
			Selectors [2].SetActive (false);
			Selectors [3].SetActive (false);
			Selectors [4].SetActive (false);
			currentBox = 1;

            if (quickItems[1] != null)
            {
                if (quickItems[1].name == "Fireball")
                {
                    ammoTxt.text = fire.SpellCount().ToString();
                }
                else if (quickItems[1].name == "Ice Spell")
                {
                    ammoTxt.text = ice.SpellCount().ToString();
                }
                else if (quickItems[1].name == "Lightening Spell")
                {
                    ammoTxt.text = lightening.SpellCount().ToString();
                }
                else if (quickItems[1].name == "Heal Spell")
                {
                    ammoTxt.text = heal.SpellCount().ToString();
                }
                else if (quickItems[1].name == "Partial Heal Spell")
                {
                    ammoTxt.text = healPartial.SpellCount().ToString();
                }
                else
                {
                    ammoTxt.text = healHalf.SpellCount().ToString();
                }
            }

		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			Selectors [0].SetActive (false);
			Selectors [1].SetActive (false);
			Selectors [2].SetActive (true);
			Selectors [3].SetActive (false);
			Selectors [4].SetActive (false);
			currentBox = 2;

            if (quickItems[2] != null)
            {
                if (quickItems[2].name == "Fireball")
                {
                    ammoTxt.text = fire.SpellCount().ToString();
                }
                else if (quickItems[2].name == "Ice Spell")
                {
                    ammoTxt.text = ice.SpellCount().ToString();
                }
                else if (quickItems[2].name == "Lightening Spell")
                {
                    ammoTxt.text = lightening.SpellCount().ToString();
                }
                else if (quickItems[2].name == "Heal Spell")
                {
                    ammoTxt.text = heal.SpellCount().ToString();
                }
                else if (quickItems[2].name == "Partial Heal Spell")
                {
                    ammoTxt.text = healPartial.SpellCount().ToString();
                }
                else
                {
                    ammoTxt.text = healHalf.SpellCount().ToString();
                }
            }
		}
		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			Selectors [0].SetActive (false);
			Selectors [1].SetActive (false);
			Selectors [2].SetActive (false);
			Selectors [3].SetActive (true);
			Selectors [4].SetActive (false);
			currentBox = 3;

            if (quickItems[3] != null)
            {
                if (quickItems[3].name == "Fireball")
                {
                    ammoTxt.text = fire.SpellCount().ToString();
                }
                else if (quickItems[3].name == "Ice Spell")
                {
                    ammoTxt.text = ice.SpellCount().ToString();
                }
                else if (quickItems[3].name == "Lightening Spell")
                {
                    ammoTxt.text = lightening.SpellCount().ToString();
                }
                else if (quickItems[3].name == "Heal Spell")
                {
                    ammoTxt.text = heal.SpellCount().ToString();
                }
                else if (quickItems[3].name == "Partial Heal Spell")
                {
                    ammoTxt.text = healPartial.SpellCount().ToString();
                }
                else
                {
                    ammoTxt.text = healHalf.SpellCount().ToString();
                }
            }
		}
		if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			Selectors [0].SetActive (false);
			Selectors [1].SetActive (false);
			Selectors [2].SetActive (false);
			Selectors [3].SetActive (false);
			Selectors [4].SetActive (true);
			currentBox = 4;

            if (quickItems[4] != null)
            {
                if (quickItems[4].name == "Fireball")
                {
                    ammoTxt.text = fire.SpellCount().ToString();
                }
                else if (quickItems[4].name == "Ice Spell")
                {
                    ammoTxt.text = ice.SpellCount().ToString();
                }
                else if (quickItems[4].name == "Lightening Spell")
                {
                    ammoTxt.text = lightening.SpellCount().ToString();
                }
                else if (quickItems[4].name == "Heal Spell")
                {
                    ammoTxt.text = heal.SpellCount().ToString();
                }
                else if (quickItems[4].name == "Partial Heal Spell")
                {
                    ammoTxt.text = healPartial.SpellCount().ToString();
                }
                else
                {
                    ammoTxt.text = healHalf.SpellCount().ToString();
                }
            }

		}

	}

	void Setter()
	{
		if (active1 == true) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				quickItems [0] = items [0];
				Debug.Log ("Quick item slot 1 is " + quickItems [0].ToString ());
				UpdateQuickbar ();
				active1 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				quickItems [1] = items [0];
				Debug.Log ("Quick item slot 2 is " + quickItems [0].ToString ());
				UpdateQuickbar ();
				active1 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				quickItems [2] = items [0];
				Debug.Log ("Quick item slot 3 is " + items [0].ToString ());
				UpdateQuickbar ();
				active1 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				quickItems [3] = items [0];
				Debug.Log ("Quick item slot 4 is " + items [0].ToString ());
				UpdateQuickbar ();
				active1 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				quickItems [4] = items [0];
				Debug.Log ("Quick item slot 5 is " + items [0].ToString ());
				UpdateQuickbar ();
				active1 = false;
			}
		}

		if (active2 == true) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				quickItems [0] = items [1];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 1 is " + items [1].ToString ());
				active2 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				quickItems [1] = items [1];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 2 is " + items [1].ToString ());
				active2 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				quickItems [2] = items [1];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 3 is " + items [1].ToString ());
				active2 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				quickItems [3] = items [1];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 4 is " + items [1].ToString ());
				active2 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				quickItems [4] = items [1];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 5 is " + items [0].ToString ());
				active2 = false;
			}
		}
	
		if (active3 == true) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				quickItems [0] = items [2];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 1 is " + items [2].ToString ());
				active3 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				quickItems [1] = items [2];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 2 is " + items [2].ToString ());
				active3 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				quickItems [2] = items [2];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 3 is " + items [2].ToString ());
				active3 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				quickItems [3] = items [2];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 4 is " + items [2].ToString ());
				active3 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				quickItems [4] = items [2];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 5 is " + items [0].ToString ());
				active3 = false;
			}
		}


		if (active4 == true) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				quickItems [0] = items [3];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 1 is " + items [3].ToString ());
				active4 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				quickItems [1] = items [3];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 2 is " + items [3].ToString ());
				active4 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				quickItems [2] = items [3];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 3 is " + items [3].ToString ());
				active4 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				quickItems [3] = items [3];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 4 is " + items [3].ToString ());
				active4 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				quickItems [4] = items [3];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 5 is " + items [3].ToString ());
				active4 = false;
			}
		}

		if (active5 == true) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				quickItems [0] = items [4];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 1 is " + items [4].ToString ());
				active5 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				quickItems [1] = items [4];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 2 is " + items [4].ToString ());
				active5 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				quickItems [2] = items [4];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 3 is " + items [4].ToString ());
				active5 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				quickItems [3] = items [4];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 4 is " + items [4].ToString ());
				active5 = false;
                ammoTxt.text = 0.ToString();
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				quickItems [4] = items [4];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 5 is " + items [4].ToString ());
				active5 = false;
			}
		}

		if (active6 == true) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				quickItems [0] = items [5];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 1 is " + items [5].ToString ());
				active6 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				quickItems [1] = items [5];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 2 is " + items [5].ToString ());
				active6 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				quickItems [2] = items [5];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 3 is " + items [5].ToString ());
				active6 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha4)) {
				quickItems [3] = items [5];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 4 is " + items [5].ToString ());
				active6 = false;
			}
			if (Input.GetKeyDown (KeyCode.Alpha5)) {
				quickItems [4] = items [5];
				UpdateQuickbar ();
				Debug.Log ("Quick item slot 5 is " + items [5].ToString ());
				active6 = false;
			}
		}
	}
	int returnIndex(string name)
	{
		for (int i = 0; i < items.Count; i++)
		{
			if (items [i].name == name)
				return i;
		}
		return -1;
	}

	void Use()
	{
		int index = 0;
		if (quickItems [currentBox].name == "Fireball" && fire.SpellCount () > 0) 
		{
			Instantiate (fireObj, tome.position, tome.rotation);
			Debug.Log (quickItems [currentBox].name);
			fire.SubtractSpellAmount ();
			index = returnIndex (quickItems [currentBox].name);
			amtText = inventoryPanel.Find ("Item Quantity " + (index +1)).GetComponent<Text> ();
			amtText.text = fire.SpellCount().ToString ();
			ammoTxt.text = fire.SpellCount ().ToString ();
			if (fire.SpellCount() == 0)
			{
				items.Remove (quickItems [currentBox]);
				quickItems [currentBox] = null;
				UpdateQuickbar ();
			}
		} 
		else if (quickItems [currentBox].name == "Lightening Spell"  && lightening.SpellCount () > 0)
		{
			Instantiate (lightObj, tome.position, tome.rotation);
			Debug.Log (quickItems [currentBox].name);
			lightening.SubtractSpellAmount ();
			index = returnIndex (quickItems [currentBox].name);
			amtText = inventoryPanel.Find ("Item Quantity " + (index+1)).GetComponent<Text> ();
			amtText.text = lightening.SpellCount().ToString ();
			ammoTxt.text = lightening.SpellCount ().ToString ();
			if (lightening.SpellCount() == 0)
			{
				items.Remove (quickItems [currentBox]);
				quickItems [currentBox] = null;
				UpdateQuickbar ();
			}
		} 
		else if (quickItems [currentBox].name == "Ice Spell"  && ice.SpellCount () > 0) 
		{
			Instantiate (iceObj, tome.position, tome.rotation);
			Debug.Log (quickItems [currentBox].name);
			ice.SubtractSpellAmount ();
			index = returnIndex (quickItems [currentBox].name);
			amtText = inventoryPanel.Find ("Item Quantity " + (index+1)).GetComponent<Text> ();
			amtText.text = ice.SpellCount().ToString ();
			ammoTxt.text = ice.SpellCount ().ToString ();
			if (ice.SpellCount() == 0)
			{
				items.Remove (quickItems [currentBox]);
				quickItems [currentBox] = null;
				UpdateQuickbar ();
			}
		} 
		else if (quickItems [currentBox].name == "Heal Spell" && heal.SpellCount () > 0 && pHealth.cur_Health != pHealth.max_Health) 
		{
			Instantiate (healObj, player.position, player.rotation);
			pHealth.cur_Health += 25;
			pHealth.SetHealthBar (pHealth.cur_Health / pHealth.max_Health);
			Debug.Log (quickItems [currentBox].name);
			heal.SubtractSpellAmount ();
			amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
			amtText.text = heal.SpellCount().ToString ();
			ammoTxt.text = heal.SpellCount ().ToString ();
			if (heal.SpellCount() == 0)
			{
				items.Remove (quickItems [currentBox]);
				quickItems [currentBox] = null;
				UpdateQuickbar ();
			}
		}
		else if (quickItems [currentBox].name == "Partial Heal Spell" && healPartial.SpellCount () > 0 && pHealth.cur_Health != pHealth.max_Health) 
		{
			Instantiate (partialHealObj, player.position, player.rotation);
			pHealth.cur_Health += 50;
			pHealth.SetHealthBar (pHealth.cur_Health / pHealth.max_Health);
			Debug.Log (quickItems[currentBox].name);
			healPartial.SubtractSpellAmount();
			amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
			amtText.text = healPartial.SpellCount().ToString ();
			ammoTxt.text = healPartial.SpellCount ().ToString ();
			if (healPartial.SpellCount() == 0) 
			{
				items.Remove (quickItems [currentBox]);
				quickItems [currentBox] = null;
				UpdateQuickbar ();
			}
		}
		else if (quickItems [currentBox].name == "Half Heal Spell" && healHalf.SpellCount () > 0 && pHealth.cur_Health != pHealth.max_Health) 
		{
			Instantiate (halfHealObj, player.position, player.rotation);
			pHealth.cur_Health += 100;
			pHealth.SetHealthBar (pHealth.cur_Health / pHealth.max_Health);
			Debug.Log (quickItems[currentBox].name);
			healHalf.SubtractSpellAmount();
			amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
			amtText.text = healHalf.SpellCount().ToString ();
			ammoTxt.text = healHalf.SpellCount ().ToString ();
			if (healHalf.SpellCount() == 0)
			{
				items.Remove (quickItems [currentBox]);
				quickItems [currentBox] = null;
				UpdateQuickbar ();
			}
		} 
		else 
		{
			return;
		}
	}
    public void UpdateInventory()
    {
        for (int i = 0; i < 6; i++)
        {
            if (i < items.Count)
            {
				int curQuantity = 0;
                Text tempPlace, tempPlace1;
				Image tempSpace;
                tempPlace = GameObject.Find("Item Name " + (i + 1)).GetComponent<Text>();
				tempPlace1 = GameObject.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
                tempSpace = GameObject.Find("Item " + (i + 1)).GetComponent<Image>();
                tempPlace.text = items[i].name;
                tempSpace.sprite = Resources.Load(items[i].tag, typeof(Sprite)) as Sprite;
                Color c = tempSpace.color;
                c.a = 100;
                tempSpace.color = c;

				if (items [i].name == "Fireball") {
					curQuantity = fire.SpellCount();
				} 
				else if (items [i].name == "Ice Spell") {
					curQuantity = ice.SpellCount();
				} 
				else if (items [i].name == "Lightening Spell") {
					curQuantity = lightening.SpellCount();
				} 
				else if (items [i].name == "Heal Spell") {
					curQuantity = heal.SpellCount();
				}
				else if (items [i].name == "Partial Heal Spell") {
					curQuantity = healPartial.SpellCount();
				} 
				else if (items [i].name == "Half Heal Spell") {
					curQuantity = healHalf.SpellCount();
				}
				Debug.Log (items[i].tag);
				tempPlace1.text = curQuantity.ToString();
            }

            else
			{
				Text tempPlace, tempPlace1;
				Image tempSpace;
                tempPlace = GameObject.Find("Item Name " + (i + 1)).GetComponent<Text>();
				tempPlace1 = GameObject.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
                tempSpace = GameObject.Find("Item " + (i + 1)).GetComponent<Image>();
                tempPlace.text = "";
				tempPlace1.text = "";
                Color c = tempSpace.color;
                c.a = 0;
                tempSpace.color = c;
            }
        }
    }
	public void UpdateQuickbar()
	{	
		for (int i = 0; i < 5; i++) 
		{
			if (quickItems [i] == null) 
			{
				tempSpace1 = GameObject.Find ("QuickItem " + (i + 1)).GetComponent<Image> ();
				Color b = tempSpace1.color;
				b.a = 0;
				tempSpace1.color = b;
			}
			else
			{
				tempSpace1 = GameObject.Find ("QuickItem " + (i + 1)).GetComponent<Image> ();
				tempSpace1.sprite = Resources.Load(quickItems[i].tag, typeof(Sprite)) as Sprite;
				Color b = tempSpace1.color;
				b.a = 255;
				tempSpace1.color = b;
			}
		}
	}

    void OnTriggerEnter(Collider other)
    {
        bool itemCheck = true;
		//Text amtText;
        if (other.gameObject.tag == "Fire PickUp")
        {
			for (int i = 0; i < items.Count; i++)
            {
				if (items [i] == fireObj) 
				{
					fire.AddSpellCount(fire.Amount());
					amtText = inventoryPanel.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
					amtText.text = fire.SpellCount().ToString ();
                    itemCheck = false;

                    break;

                }
            }
            if (itemCheck == true)
            {
                items.Add(fireObj);
				fire.AddSpellCount(fire.Amount());
                amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
				amtText.text = fire.SpellCount().ToString ();
            }
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Lightening PickUp")
        {
			for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == lightObj)
                {
					lightening.AddSpellCount (lightening.Amount());
					amtText = inventoryPanel.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
					amtText.text = lightening.SpellCount().ToString ();
                    itemCheck = false;
                    break;
                }
            }
            if (itemCheck == true)
            {
                items.Add(lightObj);
				lightening.AddSpellCount(lightening.Amount());
                amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
				amtText.text = lightening.SpellCount().ToString ();
            }
            Destroy(other.gameObject);
            }

            if (other.gameObject.tag == "Ice PickUp")
            {

			for (int i = 0; i < items.Count; i++)
            {
				if (items[i] == iceObj)
                {
					ice.AddSpellCount(ice.Amount());
					amtText = inventoryPanel.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
					amtText.text = ice.SpellCount().ToString ();
                    itemCheck = false;
                    break;
                }
            }
            if (itemCheck == true)
            {
                items.Add(iceObj);
				ice.AddSpellCount(ice.Amount());
                amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
				amtText.text = ice.SpellCount().ToString ();
            }
            Destroy(other.gameObject);
            }
                if (other.gameObject.tag == "Health PickUp")
                {
					for (int i = 0; i < items.Count; i++)
                    {
						if (items[i] == healObj)
                        {
							heal.AddSpellCount(heal.Amount());
							amtText = inventoryPanel.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
							amtText.text = heal.SpellCount().ToString ();
                            itemCheck = false;
                            break;
                        }
                    }
                    if(itemCheck == true)
                    {
                         items.Add(healObj);
						 heal.AddSpellCount(heal.Amount());
						 amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
						 amtText.text = heal.SpellCount().ToString ();
                    }
                    Destroy(other.gameObject);
                }

                if (other.gameObject.tag == "Partial Heal PickUp")
                {
					for (int i = 0; i < items.Count; i++)
                    {
						if (items[i] == healPartial)
                        {
							healPartial.AddSpellCount(healPartial.Amount());
							amtText = inventoryPanel.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
							amtText.text = healPartial.SpellCount().ToString ();
                            itemCheck = false;
                            break;
                        }
                    }
                    if(itemCheck == true)
                    {
                    	items.Add(partialHealObj);
						healPartial.AddSpellCount(healPartial.Amount());
						amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
						amtText.text = healPartial.SpellCount().ToString ();
                    }
                        Destroy(other.gameObject);
                 }
                if (other.gameObject.tag == "Half Heal PickUp")
                {
					for (int i = 0; i < items.Count; i++)
                    {
					if (items[i] == halfHealObj)
                        {
							healHalf.AddSpellCount(healHalf.Amount());
							amtText = inventoryPanel.Find ("Item Quantity " + (i + 1)).GetComponent<Text> ();
							amtText.text = healHalf.SpellCount().ToString ();
                            itemCheck = false;
                            break;
                        }
                    }
                        if (itemCheck == true)
                        {
                            items.Add(halfHealObj);
							healHalf.AddSpellCount(healHalf.Amount());
							amtText = inventoryPanel.Find ("Item Quantity " + (items.Count)).GetComponent<Text> ();
							amtText.text = healHalf.SpellCount().ToString ();
                        }
                Destroy(other.gameObject);
			if (other.gameObject.name == "Goal") 
			{
				for(int i = 0; i < 5; i++)
				//{
					//if()
					//PlayerPrefs.SetString ("inv" + i, items [i].name);
					//PlayerPrefs.SetInt("inv" + i; items[i].gameObject.GetComponent<>)
				//}
				SceneManager.LoadScene (1);

			}
			if (other.gameObject.name == "Goal Two") 
			{
				SceneManager.LoadScene (2);
			}
//			if (other.gameObject.name == "Goal Three") 
//			{
//				SceneManager.LoadScene (1);
//			}
         }

    }
}
