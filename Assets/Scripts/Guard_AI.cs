using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard_AI : MonoBehaviour {
	UnityEngine.AI.NavMeshAgent nav;
	public float velocity;
	public EnemyHealth enemyhealth;
	Vector3 destination, originalLocation; 
	float distance, timer, distanceToHome; 
	Quaternion direction;
	AudioSource skeletonSound;
	public AudioClip walk, slash;
	bool playSound = false;

	// Use this for initialization
	void Start () 
	{
		skeletonSound = gameObject.GetComponent<AudioSource> ();
		originalLocation = transform.position;
		direction = transform.rotation;
		timer = 1;
		enemyhealth = GetComponent<EnemyHealth> ();
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		distanceToHome = Vector3.Distance (gameObject.transform.position, originalLocation);
		Check ();
		DistanceChecker ();

		if (distance >= 20) 
		{
			idle();
		}
			
		if (distance <= 20 && distance > 5)
			chasing ();
		if (distance < 5) 
		{
			timer -= Time.deltaTime;
			Attack ();
		}
	}
	void chasing()
	{
		nav.Resume ();
		playSound = true;
		skeletonSound.clip = walk;
		transform.GetComponent<Animation> ().Play ("Walk");
		nav.SetDestination(destination);
		if (playSound == true && !skeletonSound.isPlaying) {
			skeletonSound.Play ();
			skeletonSound.loop = true;
		}
	}
	void idle()
	{
		if (distanceToHome < 1) 
		{
			nav.Stop ();
			transform.GetComponent<Animation> ().Play ("Idle1");
			nav.velocity = Vector3.zero;
			transform.rotation = direction;
			skeletonSound.Stop ();
			skeletonSound.loop = false;
		}
		timer -= Time.deltaTime;

		if (distanceToHome >= 1 && timer <= 0) 
		{
			nav.Resume ();
			playSound = true;
			skeletonSound.clip = walk;
			transform.GetComponent<Animation> ().Play ("Walk");
			nav.SetDestination (originalLocation);
			timer = 1;
			if (playSound == true && !skeletonSound.isPlaying) {
				skeletonSound.Play ();
				skeletonSound.loop = false;
			}
		}
	}
	void Attack()
	{
		nav.velocity = Vector3.zero;
		skeletonSound.clip = slash;
		transform.GetComponent<Animation> ().Stop ("Walk");
		skeletonSound.Stop ();
		if (timer <= 0)
		{
			transform.GetComponent<Animation> ().Play ("Attack1h1");
			timer = 1;
			skeletonSound.Play ();
        }
	}
	void Check()
	{
		RaycastHit hit;
		var demonView = new Vector3(transform.position.x, transform.position.y + 6, transform.position.z);

		if(Physics.Raycast(demonView, this.transform.forward, out hit, 50))
		{
			Debug.DrawLine (demonView, hit.point, Color.red);
			var obj = hit.transform.gameObject;
			if (obj.tag == "Ramp") 
			{
				nav.speed = 150;
			}
			if (obj.tag == "Wall") 
			{
				nav.speed = 3.5f;
			}
		}
		else
			nav.speed = 3.5f;
	}
	void DistanceChecker()
	{
		destination = GameObject.Find ("girl2").transform.position;
		distance = Vector3.Distance (gameObject.transform.position, destination);
	}
}
