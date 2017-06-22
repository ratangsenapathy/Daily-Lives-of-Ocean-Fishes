using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void GoToGameScene()
	{
		SceneManager.LoadScene ("GameScene", LoadSceneMode.Single);
	}

	public void GoToInstructionsScene()
	{
		SceneManager.LoadScene ("InstructionsScene", LoadSceneMode.Single);
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit ();
		}

	}

}
