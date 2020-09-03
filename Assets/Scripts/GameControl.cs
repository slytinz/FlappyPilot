using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
  public static GameControl instance;
  public GameObject gameOverText; //Checks to see if there is an object called GameObject
  public bool gameOver = false; //Game Over text will not appear till true
  public float scrollSpeed = -1.5f;
  public Text scoreText;

  private int score = 0;

    // Start is called before the first frame update
    void Awake() //Sets up the game control before the game starts
    {
      //Making sure no other instances of gamecontrol
      if(instance == null){
        instance = this;
      }
      else if(instance != this){
        Destroy(gameObject); //destroys the instance currently at hand
      }
    }

    // Update is called once per frame
    void Update()
    {
      //See if the game is over & see if user has flapped
      if(gameOver == true && Input.GetMouseButtonDown(0)){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }

    }

    //whenever the user score's a point
    public void BirdScored(){
      if(gameOver){
        return;
      }
      score++;
      scoreText.text = "Score: " + score.ToString(); //Calculates user's total score and adds one
    }

    //Enables the Game Over message
    public void BirdDied(){
      gameOverText.SetActive(true); //Disables GameObject
      gameOver = true; //Updates the state of the game
    }
}
