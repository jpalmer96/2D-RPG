using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Experimental.UIElements;

public class BackButtonScript : MonoBehaviour {

	public Button BackButton;
	GameObject theCanvas;

	// Use this for initialization
	void Start () {
		theCanvas = new GameObject ();
		theCanvas = GameObject.Find ("Canvas");
		//Button btn = new Button ();
		Button btn = BackButton.GetComponent<Button>();
		btn.onClick.AddListener(backPress);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void backPress(){
		theCanvas.SetActive (false);
	}
}
