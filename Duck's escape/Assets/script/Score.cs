using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Score : " + CameraScript.score.ToString());
        gameObject.GetComponent<Text>().text = "Score : " + Mathf.Round(CameraScript.score).ToString();
    }
}
