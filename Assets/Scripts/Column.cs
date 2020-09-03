using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other){
    if(other.GetComponent<Birb>() != null){ //Whatever passes through the trigger, we check if it is the bird
      //if it is a Bird
      GameControl.instance.BirdScored();
    }
  }
}
