using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour {

	// Use this for initialization
	public bool isFacingRight;
	public float speed;
	private Vector2 directionVector;
	private Rigidbody2D rb;
	void Start () {
		FishCounter.fishCount++;
		rb = GetComponent<Rigidbody2D> ();
		if (isFacingRight)
			directionVector = new Vector2 (1.0f, 0.0f);
		else
			directionVector = new Vector2 (-1.0f, 0.0f);
		rb.velocity = speed * directionVector;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = Camera.main.WorldToViewportPoint (transform.position);
		if ((directionVector.x < 0.0f && position.x <= 0.05f) ||(directionVector.x > 0.0f && position.x >= 0.95f)) {
			directionVector *= -1;
			isFacingRight = !isFacingRight;
			transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
			rb.velocity = speed * directionVector;
		}

		if (position.y > 1.1f) {
			ScoreManager.score += 10;
			Destroy (this.gameObject);
			FishCounter.fishCount--;
		}
	}
}
