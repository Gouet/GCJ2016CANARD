using UnityEngine;
using System.Collections;

public class MoveRoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, transform.position.y - CameraScript.speed, transform.position.z);
	}
}
