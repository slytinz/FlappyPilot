using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
  private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameControl.instance.scrollSpeed,0); //speed the background will scroll horizontally. 0 for vertically so that it doesn't move up and down.
    }

    // Update is called once per frame
    void Update()
    {
        if(GameControl.instance.gameOver == true){
          rb2d.velocity = Vector2.zero;
        }
    }
}
