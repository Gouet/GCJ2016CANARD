using UnityEngine;
using System.Collections;

public class RoadGenerator : MonoBehaviour {

    public GameObject[] road;
    private int block = -1;
    private int newblock;
	// Use this for initialization
	void Start () {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        while ((newblock = Random.Range(0, road.Length)) == road.Length && block == road.Length);
        block = newblock;
        Instantiate(road[block], col.gameObject.transform.position + new Vector3(0, (col.gameObject.GetComponent<SpriteRenderer>().sprite.rect.size.y / col.gameObject.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit) * 4.5f), transform.rotation);
        Destroy(col.gameObject);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
