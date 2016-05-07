using UnityEngine;
using System.Collections;

public class CameraScriptTutorial : MonoBehaviour {

    public static float speed = 0.1f;
    public static float score = 0f;

	void Update() 
	{
		CameraScript.speed = speed;
	}
}
