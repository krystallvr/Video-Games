using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float maxEnemyHealth = 200f; 
    public float currentEnemyHealth = 0f;
    public GameObject HealthBar;
   

    // Use this for initialization
    void Start()
    {
        currentEnemyHealth = maxEnemyHealth;
    }
    void Update()
    {
        
    }
    public void HurtMethod(int amount)
    {
        currentEnemyHealth -= amount;
        float calc_Enemy_Health = currentEnemyHealth / maxEnemyHealth;
        SetHealthBar(calc_Enemy_Health);
        if (currentEnemyHealth <= 0)
        {
            Death();
        }
    }
		
    // Update is called once per frame
    void Death()
    {
		Destroy(gameObject);
    }
    public void SetHealthBar(float myHealth)
    {
        HealthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
    }
}
