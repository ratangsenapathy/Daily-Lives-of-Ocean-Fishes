using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackroundFill : MonoBehaviour {

	// Use this for initialization
	//private Vector3 scale;
	private SpriteRenderer sr;
	void Start () {
		sr = GetComponent<SpriteRenderer>();
		ScaleBackgroundToFill ();

	}
	
	// Update is called once per frame
	void Update () {

		//if (scale != transform.localScale) {
			ScaleBackgroundToFill ();
		//}
	}

	void ScaleBackgroundToFill()
	{
		if (sr == null) return;
		transform.localScale = new Vector3(1,1,1);
		float width = sr.sprite.bounds.size.x;
		float height = sr.sprite.bounds.size.y;
		double worldScreenHeight = Camera.main.orthographicSize * 2.0;
		double worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
		transform.localScale = new Vector3 ((float)worldScreenWidth / width,(float)worldScreenHeight / height,1.0f);
		//scale = new Vector3 ((float)worldScreenWidth / width, (float)worldScreenHeight / height, 1.0f);
	}
}
