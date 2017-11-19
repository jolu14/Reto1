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

	public Image heart1, heart2, heart3, heart4, heart5, heart6, heart7, heart8, heart9, heart10;

	

	private static Text txtScoreS;
	private static Text txtLiveS;
	private static Text txtTombS;

	private static int intScore;
	private static int intTomb;
	public static int intLives = 10;

	public int temporal;

	private bool boolGamePause;
	// Use this for initialization
	void Start () {
		boolGamePause = false;
		txtScoreS = txtScore;
		intTomb = 1000;
		txtLiveS = txtLive;
		intScore = 0;
		txtTombS = txtTomb;

		heart10.enabled = true;
		


		

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

		temporal = intLives;

		if(this.temporal == 9){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = true;
			heart5.enabled = true;
			heart6.enabled = true;
			heart7.enabled = true;
			heart8.enabled = true;
			heart9.enabled = true;
			heart10.enabled = false;
			}
			else
			if(this.temporal == 8){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = true;
			heart5.enabled = true;
			heart6.enabled = true;
			heart7.enabled = true;
			heart8.enabled = true;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 7){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = true;
			heart5.enabled = true;
			heart6.enabled = true;
			heart7.enabled = true;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 6){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = true;
			heart5.enabled = true;
			heart6.enabled = true;
			heart7.enabled = false;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 5){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = true;
			heart5.enabled = true;
			heart6.enabled = false;
			heart7.enabled = false;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 4){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = true;
			heart5.enabled = false;
			heart6.enabled = false;
			heart7.enabled = false;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 3){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = false;
			heart5.enabled = false;
			heart6.enabled = false;
			heart7.enabled = false;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 2){
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = false;
			heart4.enabled = false;
			heart5.enabled = false;
			heart6.enabled = false;
			heart7.enabled = false;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 1){
			heart1.enabled = true;
			heart2.enabled = false;
			heart3.enabled = false;
			heart4.enabled = false;
			heart5.enabled = false;
			heart6.enabled = false;
			heart7.enabled = false;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

			}
			else
			if(this.temporal == 0){
			heart1.enabled = false;
			heart2.enabled = false;
			heart3.enabled = false;
			heart4.enabled = false;
			heart5.enabled = false;
			heart6.enabled = false;
			heart7.enabled = false;
			heart8.enabled = false;
			heart9.enabled = false;
			heart10.enabled = false;

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
