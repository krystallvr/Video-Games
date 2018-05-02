using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCount : Spell {

	// Use this for initialization
	void Start () {
		startingSpellAmount = 0;
		spellCount = startingSpellAmount;
		amount = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
