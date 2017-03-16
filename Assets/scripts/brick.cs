using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

    public int strength = 1;
    public int points = 1;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        strength--;

        GetComponent<SpriteRenderer>().color = new Color(1, 0, 1, strength * 0.2f);

        if(strength == 0)
        {
            this.gameObject.SetActive(false);
            FindObjectOfType<ball>().YouBrokeABrick(points); //worth = points

        }
    }


 
}
