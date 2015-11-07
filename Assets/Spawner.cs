using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject rain;
    public GameObject myRain;
    public Vector3 myVector;
    public float myFloat;
    public float myx;
    public float myY;

	// Use this for initialization
	void Start () {
        myY = 6.0f;
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 2; i++)
        {
            myFloat = Random.Range(-10f, 10f);   
          myVector = new Vector3 (myFloat, myY, 0);
          Instantiate(rain, myVector, Quaternion.identity) ;
        }
	}
}
