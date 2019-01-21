using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MenuScript : MonoBehaviour {

	const int buttonWidth = 84;
	const int buttonHeight = 60;


	void OnGUI ()
	{
		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (2*Screen.height /3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Start")) {

			print ("Start game");

			Application.LoadLevel("Lvl1");

		}

		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (2.5f*Screen.height /3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Exit"))

		{
			Application.Quit();

		}
	}
}
