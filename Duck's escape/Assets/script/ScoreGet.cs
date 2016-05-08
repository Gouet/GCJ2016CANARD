using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreGet : MonoBehaviour {

	void Update () {
		gameObject.GetComponent<Text> ().text = "Votre score :\n" + Mathf.Round(CameraScript.score);
	}
}
