﻿using UnityEngine;
using System.Collections;

public class restartButton : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// reload current scene
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Debug.Log ("I RESTARTED!!!!");
			Application.LoadLevel("Final_Aethetics");
		}
	}
}