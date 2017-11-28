using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public GameObject player1;
	public Collider groundcol;
	public int movespeed;
	public int jumpheight;
	public bool isGrounded;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find ("player1");
		groundcol = GameObject.Find ("ground").GetComponent<BoxCollider> ();
		isGrounded = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey("left")) {
			player1.transform.Translate (Vector3.left * Time.deltaTime * movespeed);
		}

		if(Input.GetKey("right")) {
			player1.transform.Translate (Vector3.right * Time.deltaTime * movespeed);
		}
		if (isGrounded == true) {
			if (Input.GetKeyDown ("up")) {
				player1.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * jumpheight * 20);
				print ("jump");
				isGrounded = false;
			}
		}
	}
	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.name == "ground") {
			isGrounded = true;
		}


	}
}
