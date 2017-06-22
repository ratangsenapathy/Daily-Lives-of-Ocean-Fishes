using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGenerator : MonoBehaviour {

	// Use this for initialization
	public GameObject[] fishes;
	void Start () {
		Invoke ("InstantiateFishes", 0.125f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InstantiateFishes()
	{
		int noOfFishes = Random.Range (1, 2);
		for (int i = 0; i < noOfFishes; i++) {
			int randomFish = Random.Range (0, 4);
			float spawnPointX = Random.Range (0, 2) == 1 ? -0.1f : 1.1f;;
			float spawnPointY = Random.Range (0.05f, 0.5f);

			Vector3 spawnPoint = new Vector3 (spawnPointX,spawnPointY,0.0f);
			spawnPoint = Camera.main.ViewportToWorldPoint (spawnPoint);
			spawnPoint.z = 0.0f;
			Instantiate (fishes[randomFish], spawnPoint, Quaternion.identity);
			float randomTime = Random.Range(1, 3);
			Invoke ("InstantiateFishes", randomTime);
		}
	}
}
