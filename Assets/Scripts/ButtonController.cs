using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void subStartScene(string strScene_I){
		SceneManager.LoadScene(strScene_I);
	}

	public void subQuitGame(){
		Application.Quit();
	}
}
