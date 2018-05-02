using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentinelAI : MonoBehaviour {
	private UnityEngine.AI.NavMeshAgent nav;
	public Transform[] points;
	private int destPoint = 0;
	Vector3 destination;
	public EnemyHealth enemyhealth;
	public int  punchForce;
	float distance, timer; 
	AudioSource demonSound;
	public AudioClip punch, walk;
	bool playSound = false;

	// Use this for initialization
	void Start () 
	{
		demonSound = gameObject.GetComponent<AudioSource> ();
		timer = 1;
		enemyhealth = GetComponent<EnemyHealth> ();
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () 
	{
		Check();
		DistanceChecker ();
		if (distance >= 20) 
		{
			nav.Resume ();

			playSound = true;
			demonSound.clip = walk;
			if (playSound == true && !demonSound.isPlaying) {
				demonSound.Play ();
				demonSound.loop = true;
			}
			transform.GetComponent<Animation>().Play ("Walk Animation");

			if (nav.remainingDistance < 0.5f) 
			{
				Guard ();
			}
		}
		
		else 
		{
			transform.GetComponent<Animation>().Stop ("Walk Animation");
			nav.velocity = Vector3.zero;
			nav.Stop ();
			timer -= Time.deltaTime;
			if (timer < 0)
				Punch ();
		}
	}
	void DistanceChecker()
	{
		destination = GameObject.Find ("girl2").transform.position;
		distance = Vector3.Distance (gameObject.transform.position, destination);
	}

	void Punch()
	{
		demonSound.Stop ();
		demonSound.loop = false;
		demonSound.clip = punch;
		demonSound.Play ();
		transform.LookAt (destination);
		transform.GetComponent<Animation>().Play ("Punching Animation");
		timer = 2;
	}

	void Guard()
	{
		nav.destination = points [destPoint].position;
		destPoint = (destPoint + 1) % points.Length;
	}
	void Check()
	{
		RaycastHit hit;
		var demonView = new Vector3(transform.position.x, transform.position.y + 6, transform.position.z);

		if (Physics.Raycast (demonView, this.transform.forward, out hit, 50)) {
			Debug.DrawLine (demonView, hit.point, Color.red);
			var obj = hit.transform.gameObject;
			if (obj.tag == "Ramp") {
				nav.speed = 150;
			}
			if (obj.tag == "Wall") 
			{
				if (nav.speed == 150) 
				{
					nav.speed = 3.5f;
				}
			}
		} 
		else 
		{
			nav.speed = 3.5f;
		}
	}
}
