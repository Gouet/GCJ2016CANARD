using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private float[] positionTab = {-4.9f, -1.66f, 1.74f, 4.92f};
    private int position = 1;
    private int lastButton = 0;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(positionTab[position], transform.position.y, transform.position.y);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Horizontal") == 1 && position < 3 && lastButton != 1)
        {
            ++position;
            transform.position = new Vector3(positionTab[position], transform.position.y, transform.position.y);
            lastButton = 1;
        }
        else if (Input.GetAxisRaw("Horizontal") == -1 && position > 0 && lastButton != -1)
        {
            --position;
            transform.position = new Vector3(positionTab[position], transform.position.y, transform.position.y);
            lastButton = -1;
        }
        else if (Input.GetAxisRaw("Horizontal") ==0)
            lastButton = 0;
    }
}
