using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game2 : MonoBehaviour
{

	public GameObject ButtonsBG;// panelin isminde bir game obje

	public void ExitButton()
	{
		Application.Quit();
		Debug.Log("Game closed!");
	}
	/*
	void Start()
	{
		ButtonsBG.SetActive(false);

	}
	
	public static void PauseButton(string ne_geldi) // || Button
	{
		if (ne_geldi == "pause")
		{
			ButtonsBG.Setactive(true);
			Time.timeScale = 0;
		}
		else if (ne_geldi == "devamet")
		{
			ButtonsBG.SetActive(false);
			Time.timeScale = 1;
		}
		else if (ne_geldi == "settings")
		{
			SettingsBackground.setActive(true);
			ButtonsBG.setActive(false);
		} // burada settings yerine getirilmesi gereken yer 
							
	}*/
	
}