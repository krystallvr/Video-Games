using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public float targetTime = 10.0f;
    public float max_Health = 200f;
    public float cur_Health = 0f;
    public GameObject HealthBar;
	public bool grounded, knockedBack;
	public Punching punch;
	public Text health;
	public float timer = 0;
    GameObject menu, gui;

	// Use this for initialization
	void Start ()
    {
        menu = GameObject.Find("Menu System");
        gui = GameObject.Find("Player GUI");
		grounded = true;
        cur_Health = max_Health;
		health.text = cur_Health.ToString();
		//punch = GameObject.Find ("demon/Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1/Bip001 Spine2/Bip001 Spine3/Bip001 Neck/Bip001 R Clavicle/Bip001 R UpperArm/Bip001 R Forearm/Bip001 R Hand").GetComponent<Punching> ();
	}
	
	// Update is called once per frame
	void Update ()
    {
		timer += Time.deltaTime;
		if (timer >= 1)
			knockedBack = false;
	
		//punch = GameObject.Find ("demon/Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1/Bip001 Spine2/Bip001 Spine3/Bip001 Neck/Bip001 R Clavicle/Bip001 R UpperArm/Bip001 R Forearm/Bip001 R Hand").GetComponent<Punching> ();
		if (cur_Health > 200)
			cur_Health = 200;
		
		if(grounded == false && knockedBack == false)
		{
			GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			grounded = true;
		}
		health.text = cur_Health.ToString();
	}
    
    public void HurtMethod(int amount)
    {
        cur_Health -= amount;
        float calc_health = cur_Health / max_Health;
        SetHealthBar(calc_health);

        if (cur_Health <= 0)
        {
            Death();
        }
    }
    public void HealMethod(int amount)
    {
        cur_Health += amount;
        float calc_health = cur_Health / max_Health;
        SetHealthBar(calc_health);
    }
    void Death()
    {

        Destroy(gameObject);
		SceneManager.LoadScene (5);
        Destroy(menu);
        Destroy(gui);
        Cursor.lockState = CursorLockMode.None;
    }

    public void SetHealthBar(float myHealth)
    {
		HealthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), Mathf.Clamp(myHealth, 0f, 1f), HealthBar.transform.localScale.z);
    }


}
