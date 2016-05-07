using UnityEngine;
using System.Collections;

public class PlayerTutorial : MonoBehaviour {
    private float[] positionTab = {-4.9f, -1.66f, 1.74f, 4.92f};
    private int position = 1;
    private int lastButton = 0;
    static public bool jump = false;
    private float countJump = 0f;
    private float cdJump = 0f;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(positionTab[position], transform.position.y, transform.position.y);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("COLLISION");
        if (col.gameObject.tag == "Obstacle")
        {
            CameraScript.gameOver = true;
            gameObject.GetComponent<Animator>().SetBool("dead", true);
        }
    }

	// Update is called once per frame
	void Update () {
        if (CameraScript.gameOver == false)
        {
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
            else if (Input.GetAxisRaw("Horizontal") == 0)
                lastButton = 0;
            if (Input.GetAxisRaw("Jump") == 1 && CameraScript.gameOver == false && cdJump <= 0)
            {
                countJump = 1f - CameraScriptTutorial.speed / 10;
                cdJump = (1f - CameraScriptTutorial.speed / 10) * 2;
                jump = true;
            }
            if (countJump > 0)
                countJump -= Time.deltaTime;
            if (cdJump > 0)
                cdJump -= Time.deltaTime;
        }
    }
}
