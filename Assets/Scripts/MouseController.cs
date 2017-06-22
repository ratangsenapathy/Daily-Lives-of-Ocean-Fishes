using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseController : MonoBehaviour {

	// Use this for initialization
	public GameObject hook;
	public static bool isHookInstantiated;
	void Start () {
		isHookInstantiated = false;
	}
	
	void FixedUpdate () {
		if (Input.GetMouseButtonDown(0)) 
		{
			Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			Vector3 spawnPoint = new Vector3 (mousePos.x,1.05f,0.0f);
			spawnPoint = Camera.main.ViewportToWorldPoint (spawnPoint);
			spawnPoint.z = 0.0f;
			if (!isHookInstantiated) {
				GameObject hookInstance = Instantiate (hook, spawnPoint, Quaternion.identity);
				isHookInstantiated = true;
				hookInstance.GetComponent<HookController> ().TargetPosition = mousePos;
			}
		}

	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene ("GameOverScene", LoadSceneMode.Single);
		}

	}
}
