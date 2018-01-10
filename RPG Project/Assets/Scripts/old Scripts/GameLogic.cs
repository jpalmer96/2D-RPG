using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
	
	GameObject theCanvas;
	// Use this for initialization
	void Start () {
		
		theCanvas = new GameObject ();
		theCanvas = GameObject.Find ("Canvas");

	}

	void Awake(){
		theCanvas.SetActive (false);
	}
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			theCanvas.SetActive (true);
			//tree.gameObject.addComponent ("AdventureScript");
		}



	}
}
