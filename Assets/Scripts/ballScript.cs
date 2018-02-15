using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballScript : MonoBehaviour {
 
	public Rigidbody2D rb;
	public float ballForce;
	public float speed = 3f;
	bool gameStart =false; 
	public UiManager ui;

	// Use this for initialization
	void Start () { 
		rb.velocity = Vector2.up * speed;
		ui = GameObject.FindWithTag ("ui").GetComponent<UiManager>();
	}
	
	// Update is called once per frame
	void Update () { 	
		if (Input.GetKeyUp (KeyCode.Space) && gameStart == false) {
			transform.SetParent (null);
			rb.isKinematic = false;
			gameStart = true;
			rb.AddForce (new Vector2 (ballForce, ballForce));
		}

	}
 
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag.ToLower() == "blockcho") {
			ui.IncrementScore ();
			Destroy(col.gameObject); 
		 				
			// Calculate hit Factor
			float x = (transform.position.x - col.transform.position.x / col.collider.bounds.size.x);

			// Calculate direction, set length to 1
			Vector2 dirX = new Vector2(x, 1).normalized;

			// Set Velocity with dir * speed
			rb.velocity = dirX * speed;

		}
		if (col.gameObject.tag.ToLower () == "bottom") {
			Destroy(col.gameObject);	
			SceneManager.LoadScene("game-start");		
		}
	}
	 
}
