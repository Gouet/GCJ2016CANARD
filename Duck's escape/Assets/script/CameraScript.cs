using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public static float speed = 0.08f;
    public static float score = 0f;
    public static bool gameOver = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver == false)
        {
            speed += 0.008f * Time.deltaTime;
            score += 1f * Time.deltaTime;
        }
	}
}
