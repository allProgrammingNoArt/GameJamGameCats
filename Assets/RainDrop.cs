using UnityEngine;
using System.Collections;

public class RainDrop : MonoBehaviour {
    float mySpeed;

	// Use this for initialization
	void Start () {
        mySpeed = .0001f;
	}
	
	// Update is called once per frame
	void Update () {
        while (transform.position.y > -5)
        {
            transform.position += Vector3.down * Time.deltaTime * mySpeed;
        }
	}
}
