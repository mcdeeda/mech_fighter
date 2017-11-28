using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class select_start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel("Final_Aethetics");
		}
	}
}