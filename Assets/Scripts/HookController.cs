using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookController : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D rb;
	private bool isTargetSet = false;
	private bool isDirectionReversed = false;
	private Vector3 targetPosition;
	public Vector3 TargetPosition {
		set{ targetPosition = value;isTargetSet = true;}
	}
	public float speed;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		if(isTargetSet)
		rb.velocity = new Vector2 (0.0f,-1.0f) * speed;
		//transform.position = Vector3.MoveTowards(transform.position,targetPosition);
	}
	
	// Update is called once per frame
	void Update(){
		Vector3 position = Camera.main.WorldToViewportPoint (transform.position);

		if (!isDirectionReversed && position.y <= targetPosition.y) {
			rb.velocity *= -1;
			isDirectionReversed = true;
		} else if (position.y >= 1.15f) {
			Destroy (this.gameObject);
			MouseController.isHookInstantiated = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.name);
		if (other.name.Contains(TargetSelector.currentTarget)) {
			//rb.velocity *= -1;
			var otherRb = other.gameObject.GetComponent<Rigidbody2D> ();
			otherRb.velocity = new Vector2 (0.0f,1.0f) * speed;
			//isDirectionReversed = true;
		}
	}
}
