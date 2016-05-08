using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public void onClickToPlay()
    {
        SceneManager.LoadScene("Main level");
    }

    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial level");
    }

    public void resetHighscore()
    {
        PlayerPrefs.SetFloat("Highscore", 0);
    }

    public void onClickToExit()
    {
        Application.Quit();
    }
}
