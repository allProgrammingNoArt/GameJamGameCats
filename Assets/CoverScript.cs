using UnityEngine;
using System.Collections;

public class CoverScript : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.SendMessage("isHealing");
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        coll.gameObject.SendMessage("isNotHealing");
    }
}
