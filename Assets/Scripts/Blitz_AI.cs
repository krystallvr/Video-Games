using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blitz_AI : MonoBehaviour {

	private UnityEngine.AI.NavMeshAgent nav;
	public Transform[] points;
	private int destPoint = 0;
	Vector3 destination;
	public EnemyHealth enemyhealth;
	public int  crashDamage;
	float distance, timer; 
	AudioSource sheDemonSound;
	public AudioSource growl;
	public AudioClip run, walk;
	bool play = false;

	// Use this for initialization
	void Start () 
	{
		sheDemonSound = gameObject.GetComponent<AudioSource> ();
		timer = 2;
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Check ();
		DistanceChecker ();

		if(distance >= 20)
		{
			nav.Resume ();
			sheDemonSound.clip = walk;
			transform.GetComponent<Animation>().Play ("Walk Animation");

			if (!sheDemonSound.isPlaying) {
				sheDemonSound.Play ( );
				sheDemonSound.loop = true;
			}

			if (nav.remainingDistance < 0.5f) 
				Guard ();
		}

		if (distance <= 20 && distance > 14) 
		{
			if (play == true) {
				growl.Play ();
				play = false;
			}
			
				Blitz ();
		}
		if (distance <= 14) 
		{
			sheDemonSound.Stop ();
			nav.velocity = Vector3.zero;
			nav.Stop ();
			timer -= Time.deltaTime;

			if (timer < 0) 
			{	
				transform.GetComponent<Animation> ().Stop ("Running Animation");
				Crash ();
			}
		}
	}
	void Blitz()
	{
		nav.SetDestination(destination);
		
		sheDemonSound.clip = run;
		sheDemonSound.loop = true;
		if (!sheDemonSound.isPlaying) 
		{
			transform.GetComponent<Animation> ().Play ("Running animation");
			sheDemonSound.Play ();
		}
	}
	void Guard()
	{
		play = true;
		transform.GetComponent<Animation> ().Play ("Walk Animation");
		nav.destination = points [destPoint].position;
		destPoint = (destPoint + 1) % points.Length;
	}
	void Crash()
	{
		
		nav.velocity = Vector3.zero;

		if (timer <= 0) 
		{
			transform.GetComponent<Animation> ().Play ("Slamming Animation");
			timer = 1;
		}
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
				nav.speed = 3.5f;
			}
		}
		else 
		{
			nav.speed = 3.5f;
		}
	}
	void DistanceChecker()
	{
		destination = GameObject.Find ("girl2").transform.position;
		distance = Vector3.Distance (gameObject.transform.position, destination);
	}
}
