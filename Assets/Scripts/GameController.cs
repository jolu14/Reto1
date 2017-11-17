using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Text txtScore;
	public Text txtLive;
	public Text txtTomb;
	public Text txtPause;

	private static Text txtScoreS;
	private static Text txtLiveS;
	private static Text txtTombS;

	private static int intScore;
	private static int intTomb;
	public static int intLives = 15;

	private bool boolGamePause;
	// Use this for initialization
	void Start () {
		boolGamePause = false;
		txtScoreS = txtScore;
		intTomb = 1000;
		txtLiveS = txtLive;
		intScore = 0;
		txtTombS = txtTomb;
	}
	
	// Update is called once per frame
	void Update () {


		if (intLives <= 0){
			SceneManager.LoadScene("Scenes/Lose");
		}

		if (intTomb <= 0){
			SceneManager.LoadScene("Scenes/Win");
		}

		if(Input.GetKey(KeyCode.Escape))
		{
			if (!boolGamePause)
			{
				Time.timeScale =0;
				AudioListener.pause = true;
				boolGamePause = true;
				txtPause.text = "Pause\n Press 'e' to exit";
			}
			else{
				Time.timeScale =1;
				AudioListener.pause = false;
				boolGamePause = false;
				txtPause.text = "Press 'esc' to pause";
			}
		}

		if(Input.GetKey(KeyCode.E))
		{
			if (boolGamePause){
				SceneManager.LoadScene("Scenes/Start");
			}
		}


	}

	public static void subAddScore(int intScore_I){
		intScore += intScore_I;
		txtScoreS.text = "Score " + intScore ;
	}

	public static void subHitTomb(int intHit){
		intTomb -= intHit;
		txtTombS.text = "Tomb Live " + ((float)intTomb) * 100.0f / 1000.0f + "%";
	}

	public static void subHitPlayer(int intLives_I){
		intLives -= intLives_I;
		string strLives = "";

		for (int intX = 0; intX < intLives; intX++ ){
			strLives += "-";
		}

		txtLiveS.text = "Live " + strLives;
	}
}
