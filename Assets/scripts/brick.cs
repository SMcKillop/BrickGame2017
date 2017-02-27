using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

	// Use this for initialization
	void Start () {


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        gameObject.SetActive(false);
    }
}
