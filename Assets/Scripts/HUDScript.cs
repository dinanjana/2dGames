using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {


	float playerScore = 10;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		playerScore -= (Time.deltaTime);

		if (playerScore <= 0) {
				
			Application.LoadLevel(1);
			return;
		}
		if((int)playerScore == 1000){

			Application.LoadLevel(2);
			return;
		}
	
	}

	public void IncreaseScore(int amount){

		playerScore += amount;

	}

	void OnDisable(){

		PlayerPrefs.SetInt ("Score",(int)(playerScore*100));

	}

	void OnGUI(){

		GUI.Label (new Rect(10,10,100,30),"Energy :"+(int)(playerScore*10));
	}
}
