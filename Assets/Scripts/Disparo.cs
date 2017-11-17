using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	public Rigidbody Bala = null;
	public float speed = 100;
	public float multiplier = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if ( Input.GetButton ("Fire1")) 
		{
			Rigidbody clone = Instantiate(Bala, transform.position, transform.rotation);
			clone.velocity = transform.TransformDirection( new  Vector3 (0, speed, 0));
			Destroy (clone.gameObject, 1);
		

		var systems = GetComponentsInChildren<ParticleSystem>();
		foreach (ParticleSystem system in systems)
		{
			ParticleSystem.MainModule mainModule = system.main;
			mainModule.startSizeMultiplier *= multiplier;
			mainModule.startSpeedMultiplier *= multiplier;
			mainModule.startLifetimeMultiplier *= Mathf.Lerp(multiplier, 1, 0.5f);
			system.Clear();
			system.Play();
		}
		}
	}
}
