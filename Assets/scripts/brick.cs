using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

    public int strength = 1;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        strength--;
        if(strength == 0)
        {
            this.gameObject.SetActive(false);
            FindObjectOfType<ball>().YouBrokeABrick();

        }
    }


 
}
