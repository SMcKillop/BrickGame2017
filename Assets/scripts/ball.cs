using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

   public Vector2 startingVelocity = new Vector2(5, -20);
    private Vector3 startingPosition;
    public GameObject gameOver;

    int lives = 3; 

    // Use this for initialization
    void Start () {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
	}
	
	// Update is called once per frame
	void Update () {
	    if(transform.position.y < -3.5f)
        {
            GetOut();
        }
        if(Input.GetButtonDown("Jump")) {
            GetComponent<Rigidbody2D>().velocity = startingVelocity;
    }

        void GetOut();
    {
        Debug.Log("You are out");
        lives = lives - 1;

        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();
        if (lives == 0)
        {
            DoGameOver();
        }    
    }

    void DoGameOver() {

        gameOver.SetActive(true);}
}
