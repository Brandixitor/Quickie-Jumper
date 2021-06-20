using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

void Start()
    {
      // This will hopefully auto rotate the screen upon launch (doesn't work when ScreenRotate is off!!!)
        Screen.autorotateToPortrait = true;

        Screen.autorotateToPortraitUpsideDown = true;

        Screen.orientation = ScreenOrientation.AutoRotation;
    }




  //Function to start the game upon clicking on PLAY.
    public void PlayGame ()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

       //Function to quit the game upon clicking on QUIT.
   public void QuitGame ()
  {
    Debug.Log("Quit!");
     if (Input.GetKeyDown(KeyCode.Escape))
 { 
      Application.Quit();
 }
  }

}
