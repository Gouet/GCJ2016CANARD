using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public void backToMenu(){
		SceneManager.LoadScene ("menu");
	}

	public void resumeGame(){
		CameraScript.switchPauseMenu ();
	}

	public void exitGame(){
//		PlayerPrefs.SetFloat("Highscore", Mathf.Max(PlayerPrefs.GetFloat("Highscore"), Mathf.Round(CameraScript.score)));
		Application.Quit ();
	}

	public void retryGame(){
		CameraScript.score = 0f;
		CameraScript.speed = 0.08f;
		CameraScript.gameOver = false;
		SceneManager.LoadScene ("Main level");
	}
}
