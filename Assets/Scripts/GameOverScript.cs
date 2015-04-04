using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	int score = 0;
	void Start () {
	
		score = PlayerPrefs.GetInt("Score");
	}
	void OnGUI(){

		GUI.Label(new Rect(Screen.width/2-40,50,130,30),"You're Fucked :p");
		GUI.Label (new Rect (Screen.width / 2 - 40, 150, 80, 30), "Score " + score);

		if (GUI.Button (new Rect (Screen.width / 2 - 30, 200, 100, 30), "Retry?? :p")) {
			Application.LoadLevel(0);		
		}

	}

}
