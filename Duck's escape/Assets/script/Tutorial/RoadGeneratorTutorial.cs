using UnityEngine;
using System.Collections;

public class RoadGeneratorTutorial : MonoBehaviour {

    public GameObject road;
	public GameObject[] roadGame;

	// Use this for initialization
	void Start () {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
		if (GameObject.Find ("Player").GetComponent<TutorialProgress> ().nowPlaying) {
			GameObject.Find ("Player").GetComponent<TutorialProgress> ().count--;
			if (GameObject.Find("Player").GetComponent<TutorialProgress> ().count - 2 >= 0 && GameObject.Find("Player").GetComponent<TutorialProgress> ().count - 2 < roadGame.Length)
				Instantiate(roadGame[GameObject.Find("Player").GetComponent<TutorialProgress> ().count - 2], col.gameObject.transform.position + new Vector3(0, (col.gameObject.GetComponent<SpriteRenderer>().sprite.rect.size.y / col.gameObject.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit) * 4.5f), transform.rotation);
			else
				Instantiate(road, col.gameObject.transform.position + new Vector3(0, (col.gameObject.GetComponent<SpriteRenderer>().sprite.rect.size.y / col.gameObject.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit) * 4.5f), transform.rotation);
		}
		else
	        Instantiate(road, col.gameObject.transform.position + new Vector3(0, (col.gameObject.GetComponent<SpriteRenderer>().sprite.rect.size.y / col.gameObject.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit) * 4.5f), transform.rotation);
        Destroy(col.gameObject);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
