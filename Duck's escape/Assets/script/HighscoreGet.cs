using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighscoreGet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text> ().text = "Meilleur score :\n" + PlayerPrefs.GetFloat ("Highscore");
	}
}
