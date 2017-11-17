using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

	public GameObject CompleteZombie;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "bullet")
		{
			Destroy(collision.gameObject);
			Destroy(CompleteZombie);
			GameController.subAddScore(1);
		}
		else if (collision.gameObject.tag == "Player"){

			CompleteZombie.gameObject.GetComponent<FollowMe>().boolOnPlayerRadius = true;
			anim.Play("attack");
			GameController.subHitPlayer(1);
		}
	}

	void OnTriggerExit(Collider collision)
	{
		if (collision.gameObject.tag == "Player"){
			CompleteZombie.gameObject.GetComponent<FollowMe>().boolOnPlayerRadius = false;
			anim.Play("walk");
		}
	}
}
