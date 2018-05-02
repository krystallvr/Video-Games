using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartialHealCount : Spell {

	// Use this for initialization
	void Start () {
		startingSpellAmount = 0;
		spellCount = startingSpellAmount;
		amount = 4;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
