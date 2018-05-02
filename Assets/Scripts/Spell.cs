using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {

    protected int damage, spellSpeed;
    public int amount, startingSpellAmount, spellCount;

    public void SubtractSpellAmount()
    {
        spellCount--;
    }
	public int SpellCount()
	{
		return spellCount;
	}
	public int Amount()
	{
		return amount;
	}
    public void AddSpellCount(int amount)
    {
        spellCount += amount;
    }
}
