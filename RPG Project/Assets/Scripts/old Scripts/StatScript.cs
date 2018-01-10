using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatScript : MonoBehaviour {

	//Member Variables
	//MenuScript menuScript;
	public GameObject theCanvas;

	public void Start(){
		//menuScript = new MenuScript ();
	}



	void OnMouseDown(){					
		theCanvas.GetComponent<Canvas>().enabled = true;
	}
}
