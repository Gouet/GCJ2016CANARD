using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TutorialProgress : MonoBehaviour {

	private GameObject target;
	public int count = 5;
	public int pos = 1;
	private int lastInput = 0;
	private GameObject obj;
	private int timer = 4;
	public bool nowPlaying = false;

	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("Timer");
		target = GameObject.Find ("TutorialText");
	}

	IEnumerator prepareStart()
	{
		obj.GetComponent<Text> ().enabled = true;
		while (--timer > 0) {
			yield return new WaitForSeconds (1);
		}
		SceneManager.LoadScene ("Main level");
	}

	// Update is called once per frame
	void Update () {
		if (pos > 0 && Input.GetAxisRaw ("Horizontal") == -1 && lastInput != -1) {
			pos--;
			lastInput = -1;
		} else if (pos < 3 && Input.GetAxisRaw ("Horizontal") == 1 && lastInput != 1) {
			pos++;
			lastInput = 1;
		} else if (Input.GetAxisRaw ("Horizontal") == 0)
			lastInput = 0;
		
		if (Input.GetAxisRaw("Horizontal") != 0 && !nowPlaying)
		{
			target.GetComponent<Text> ().text = "Evitez les obstacles en vous déplaçant sur la route. Et essayez d'aller le plus loin possible.";
			GameObject.Find ("MessageBox").GetComponent<RectTransform>().sizeDelta = new Vector2(GameObject.Find("MessageBox").GetComponent<RectTransform>().sizeDelta.x, 40);
			GameObject.Find("MessageBoxInside").GetComponent<RectTransform>().sizeDelta = new Vector2(GameObject.Find("MessageBoxInside").GetComponent<RectTransform>().sizeDelta.x, 28);
			GameObject.Find ("MessageBox").transform.position = GameObject.Find("MessageBox").transform.position + new Vector3 (0, GameObject.Find("MessageBox").transform.localScale.y / 3, 0);
			nowPlaying = true;
		}

		if (count == 4 && pos == 1 && CameraScript.speed == 0f)
			CameraScriptTutorial.speed = 0.1f;
		if (count == 3 && pos == 3 && CameraScript.speed == 0f)
			CameraScriptTutorial.speed = 0.1f;
		if (count == 2 && pos == 3 && CameraScript.speed == 0f)
			CameraScriptTutorial.speed = 0.1f;

		if (nowPlaying && count <= 0 && timer == 4) {
			target.GetComponent<Text> ().text = "Le jeu va maintenant démarrer. Préparez vous à fuir les poulets !";
			StartCoroutine (prepareStart ());
		}
		obj.GetComponent<Text> ().text = timer.ToString ();
	}
}
