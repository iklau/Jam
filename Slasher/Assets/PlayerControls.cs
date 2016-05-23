using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float xOffset = Input.GetAxis("Horizontal");
		float yOffset = Input.GetAxis("Vertical");
		Vector2 newPos = new Vector2(transform.position.x + xOffset, transform.position.y + yOffset);
		rb.MovePosition(newPos);
	}
}
