using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
  public float upForce = 200f; //used to create a new vector2 as the Y axis
  private bool isDead = false;
  private Rigidbody2D rb2d;
  private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //Check the game object if there is a component of type Rigidbody (Allows physics stuff)
        anim = GetComponent<Animator>(); //Check the game object if there is a component of type Animator
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == false){ //Check if user is still alive
          if(Input.GetMouseButtonDown(0)){ //If the player has left clicked
            rb2d.velocity = Vector2.zero; //Rigidbody will either be rising or falling. Velocity is reset to 0 whenever player jumps
            rb2d.AddForce(new Vector2(0,upForce));
            //X axis is 0 due to player not moving horizontally
            //Y axis is a constant 200f
            anim.SetTrigger("Flap"); //Inserts the flap animation when clicking
          }
        }
    }

    void OnCollisionEnter2D(){
      rb2d.velocity = Vector2.zero; //prevents bird from sliding when colliding
      isDead = true;
      anim.SetTrigger("Die"); //Inserts the death animation when Collision occurs
      GameControl.instance.BirdDied(); //Acesses the death of bird
    }
}
