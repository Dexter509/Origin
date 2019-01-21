using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {
	const int buttonWidth = 120;
	const int buttonHeight = 60;


	void OnGUI ()
	{ 


		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (1*Screen.height /3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Restart")) 
		{
			print ("Start game");
			Application.LoadLevel("Lvl1");

		}

		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (2*Screen.height /3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Back to menu"))

		{
			Application.LoadLevel("Menu");

		}

		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (2.5f*Screen.height /3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Exit"))

		{
			Application.Quit();

		}

	}
}
