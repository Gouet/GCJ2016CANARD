using UnityEngine;
using System.Collections;

public class PlayerTutorial : MonoBehaviour {
    private float[] positionTab = {-4.9f, -1.66f, 1.74f, 4.92f};
    private int position = 1;
    private int lastButton = 0;
    static public bool jump = false;
    private float countJump = 0f;
    private float cdJump = 0f;
    public AudioClip boing;
    public AudioClip stop;
    public AudioClip coin;
    public AudioClip fall;
    private AudioSource audiosrc;

    // Use this for initialization
    void Start () {
        transform.position = new Vector3(positionTab[position], transform.position.y, transform.position.y);
        audiosrc = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {
        if (CameraScript.gameOver == false)
        {
            if (Input.GetAxisRaw("Horizontal") == 1 && position < 3 && lastButton != 1)
            {
                int chanceCoin = Random.Range(0, 3);
                if (chanceCoin == 0)
                    audiosrc.PlayOneShot(coin);
                ++position;
                transform.position = new Vector3(positionTab[position], transform.position.y, transform.position.y);
                lastButton = 1;
            }
            else if (Input.GetAxisRaw("Horizontal") == -1 && position > 0 && lastButton != -1)
            {
                int chanceCoin = Random.Range(0, 3);
                if (chanceCoin == 0)
                    audiosrc.PlayOneShot(coin);
                --position;
                transform.position = new Vector3(positionTab[position], transform.position.y, transform.position.y);
                lastButton = -1;
            }
            else if (Input.GetAxisRaw("Horizontal") == 0)
                lastButton = 0;
            if (Input.GetAxisRaw("Jump") == 1 && CameraScript.gameOver == false && cdJump <= 0)
            {
                audiosrc.PlayOneShot(boing);
                countJump = 1f - CameraScript.speed ;
                cdJump = (1f - CameraScript.speed) * 2;
                gameObject.GetComponent<Animator>().speed = 1f / countJump;
                gameObject.GetComponent<Animator>().SetBool("jump", true);
                jump = true;
            }
            if (countJump > 0)
                countJump -= Time.deltaTime;
            if (cdJump > 0)
                cdJump -= Time.deltaTime;
            if (countJump <= 0)
            {
                jump = false;
                gameObject.GetComponent<Animator>().speed = 1f;
                gameObject.GetComponent<Animator>().SetBool("jump", false);
            }
        }
    }
}
