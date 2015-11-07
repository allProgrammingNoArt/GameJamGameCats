using UnityEngine;
using System.Collections;

public class CatStuff : MonoBehaviour {
    float speed = 2.0f;
    Animator playerAnimator;
    public bool trigger;
    Rigidbody2D myBody;
    public bool underCover;

	// Use this for initialization
	void Start () {

        playerAnimator = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
        underCover = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        
        
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        if (Input.GetAxis("Horizontal") < 0)
        {
            if (playerAnimator.GetBool("Stopped") == true)
            {
                playerAnimator.SetBool("Stopped", false);
            }
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            if (playerAnimator.GetBool("Stopped") == true)
            {
                playerAnimator.SetBool("Stopped", false);
            }
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            playerAnimator.SetBool("Stopped", true);
        }

        if (Input.GetButtonDown("Jump"))
        {
            myBody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
        transform.position += move * speed * Time.deltaTime;
        
	}
}
