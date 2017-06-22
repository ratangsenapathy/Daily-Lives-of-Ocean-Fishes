using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FishCounter : MonoBehaviour {

	public static int fishCount;
	private Text counterText;
	// Use this for initialization
	void Start () {
		fishCount = 0;
		counterText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		counterText.text = "Fishes: " + fishCount + "/30";
		if (fishCount >=30) {
			SceneManager.LoadScene ("GameOverScene", LoadSceneMode.Single);
		}
	}
}
