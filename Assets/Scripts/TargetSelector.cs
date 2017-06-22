using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetSelector : MonoBehaviour {

	// Use this for initialization
	private Image im;
	public Sprite[] fishes;
	public static string currentTarget;
	void Start () {
		im = GetComponent<Image> ();
		ChangeTarget ();
	}
	
	// Update is called once per frame
	void ChangeTarget () {
		im.sprite = fishes [Random.Range (0, 4)];
		currentTarget = im.sprite.name;
		Invoke ("ChangeTarget", 3.0f);
	}
}
