using UnityEngine;
using System.Collections;

public class CatStuff : MonoBehaviour {
    float speed = 2.0f;
    Animator playerAnimator;
    public bool trigger;
    Rigidbody2D myBody;
    public bool underCover;
	public bool hasJumped;
	// Use this for initialization
	void Start () {

        playerAnimator = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
        underCover = false;
		hasJumped = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (underCover)
        {
            Debug.Log("Is healing");
        }
        else
        {
            Debug.Log("Is not healing");
        }
        
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

        if (Input.GetButtonDown("Jump") && hasJumped == false)
        {
			hasJumped = true;
			myBody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
			//if(Collision2D.gameObject.name == GameObject.Find("Platform"){
			//	hasJumped = false;
			//}
		}
        transform.position += move * speed * Time.deltaTime;
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        
	}

    public void isHealing()
    {
        underCover = true;
    }

    public void isNotHealing()
    {
        underCover = false;
    }
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Platform" || coll.gameObject.tag == "Kitten") {
			hasJumped = false;
		}
	}
}
