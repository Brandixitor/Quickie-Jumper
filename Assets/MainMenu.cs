using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  //Function to start the game upon clicking on PLAY.
    public void PlayGame ()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }



}
