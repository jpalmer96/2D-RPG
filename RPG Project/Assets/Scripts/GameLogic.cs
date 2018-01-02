using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
	GameObject tree;
	GameObject theCanvas;
	// Use this for initialization
	void Start () {
		
		tree = new GameObject();
		tree = GameObject.Find ("Tree_1");
		theCanvas = new GameObject ();
		theCanvas = GameObject.Find ("Canvas");
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
