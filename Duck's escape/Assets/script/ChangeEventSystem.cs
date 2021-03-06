﻿using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ChangeEventSystem : MonoBehaviour {

	public GameObject firstPause;
	public GameObject firstGameover;
	private bool isOver = false;
	private bool isOnPause = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CameraScript.gameOver && !isOver) {
			isOver = true;
			gameObject.GetComponent<EventSystem> ().firstSelectedGameObject = firstGameover;
			gameObject.GetComponent<EventSystem> ().enabled = false;
			gameObject.GetComponent<EventSystem> ().enabled = true;
		}
		else if (!CameraScript.gameOver) {
			isOver = false;
			if (CameraScript.isPaused && !isOnPause) {
				isOnPause = true;
				gameObject.GetComponent<EventSystem> ().firstSelectedGameObject = firstPause;
				gameObject.GetComponent<EventSystem> ().enabled = false;
				gameObject.GetComponent<EventSystem> ().enabled = true;
			} else if (!CameraScript.isPaused)
				isOnPause = false;
		}
	}
}
