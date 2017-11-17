using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Text txtDanger;
	float fHit = 0.0f;
	// Use this for initialization
	void Start () {
		txtDanger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other) {
		if (txtDanger.enabled){
			fHit += 0.01f;

			if (fHit >= 1){
				GameController.subHitPlayer(1);
				fHit = 0.0f;
			}

		}
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Finish"){
			txtDanger.enabled = true;

		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Finish"){
			txtDanger.enabled = false;
		}
	}
}
