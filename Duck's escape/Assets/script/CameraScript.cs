using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public static float speed = 0.1f;
    public static float score = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        speed += 0.01f;
        score += 1f;
	}
}
