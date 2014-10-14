using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	void OnGUI() {

		if (GUI.Button (new Rect (60, 10, 300, 300), "Head Tracking")) {
				Application.LoadLevel ("Head Tracking");
		}
		
		if (GUI.Button (new Rect (400, 10, 300, 300), "Ball Game")) {
				Application.LoadLevel ("Ball Game");
		}

		if (GUI.Button (new Rect (60, 330, 640, 200), "Exit")) {
				Application.Quit();
		}

	}
	void Update(){
	}
}
