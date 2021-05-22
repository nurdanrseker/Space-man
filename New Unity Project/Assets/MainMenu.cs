using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void ExitButton(){
        Application.Quit();
        Debug.Log("Game closed!");
    }

    /* Oyuna giri� yaparken Single Player se�ilirse--> "Game1" kullan�lacak! */
    /* Oyuna giri� yaparken Multiplayer se�ilirse--> "Game2" kullan�lacak! */
   
    public void PlayGame1() { 
        SceneManager.LoadScene("Game1"); 
    }
    
    public void PlayGame2() {
          SceneManager.LoadScene("Game2");
    }
}
