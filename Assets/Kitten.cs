using UnityEngine;
using System.Collections;

public class Kitten : MonoBehaviour {

    float time;
    AudioSource mySource;
	// Use this for initialization
	void Start () {
        time = 0;
        mySource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (time >= 10)
        {
            mySource.Play();
            time = 0;
        }
        time += Time.deltaTime;
        Debug.Log(time);
	}
}
