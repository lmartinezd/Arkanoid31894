using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed = 4f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
	}

	void FixedUpdate () {
		float moveX = Input.GetAxisRaw ("Horizontal");  		
		rb.velocity = Vector2.right * moveX * speed;
	}

}
