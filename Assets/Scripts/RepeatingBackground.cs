using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
  private BoxCollider2D groundCollider;
  private float groundHorizontalLength;

    // Start is called before the first frame update
    void Start()
    {
      groundCollider=GetComponent<BoxCollider2D>();
      groundHorizontalLength = groundCollider.size.x; //Get size of the collider and store that into float

    }

    // Update is called once per frame
    void Update()
    {
      if(transform.position.x < -groundHorizontalLength){ //calculate if horizontal is scrolled to it's full length to the left
        RepositionBackground();
      }
    }

    
    private void RepositionBackground(){
      Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0); //Double the length of the collider & jump our object past the one that's visible into new position in front so it is ready to be seen.
      transform.position = (Vector2)transform.position + groundOffset;//Calculate how much it needs to move and move scenery.

    }
}
