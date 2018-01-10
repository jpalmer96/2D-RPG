using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathScript : MonoBehaviour {
	
	//Member Variables
	public GameObject theCanvas;

	void OnMouseDown(){	
		
		//menuScript.theCanvas.GetComponent<Canvas> ().enabled = true;
		theCanvas.GetComponent<Canvas>().enabled = true;
	}
}
