using UnityEngine;
using System.Collections;

public class PauseScriptTutorial : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		int x = GameObject.Find("Player").GetComponent<TutorialProgress>().count;
		int y = GameObject.Find ("Player").GetComponent<TutorialProgress> ().pos;
		if (x == 4 && y != 1)
			CameraScriptTutorial.speed = 0f;
		else if (x == 3 && y != 3)
			CameraScriptTutorial.speed = 0f;
		else if (x == 2 && y != 3)
			CameraScriptTutorial.speed = 0f;
	}
}
