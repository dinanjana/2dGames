using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

	void OnGUI(){

		GUI.Label(new Rect(Screen.width/2-40,50,300,70),"You Won :D");
	}
}
