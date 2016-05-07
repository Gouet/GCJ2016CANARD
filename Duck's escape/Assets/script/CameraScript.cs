using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public static float speed = 0.08f;
	private static float oldSpeed = speed;
    public static float score = 0f;
    public static bool gameOver = false;
	public static bool isPaused = false;
    public AudioClip alarm;
    private AudioSource audiosrc;
	public GameObject PauseCanvas;

    // Use this for initialization
    void Start () {
        audiosrc = GetComponent<AudioSource>();
        audiosrc.PlayOneShot(alarm);
    }

	public static void switchPauseMenu(){
		isPaused = !isPaused;
		if (isPaused) {
			oldSpeed = speed;
			speed = 0;
		} else
			speed = oldSpeed;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Cancel")) {
			switchPauseMenu ();
		}
		if (isPaused)
			PauseCanvas.SetActive (true);
		else
			PauseCanvas.SetActive (false);

		if (gameOver == false && isPaused == false)
        {
            if (speed <= 0.4f)
                speed += 0.004f * Time.deltaTime;
            score += 3f * Time.deltaTime;
        }
	}
}
