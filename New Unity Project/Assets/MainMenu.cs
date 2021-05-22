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

    /* Oyuna giriþ yaparken Single Player seçilirse--> "Game1" kullanýlacak! */
    /* Oyuna giriþ yaparken Multiplayer seçilirse--> "Game2" kullanýlacak! */
   
    public void PlayGame1() { 
        SceneManager.LoadScene("Game1"); 
    }
    
    public void PlayGame2() {
          SceneManager.LoadScene("Game2");
    }
}
