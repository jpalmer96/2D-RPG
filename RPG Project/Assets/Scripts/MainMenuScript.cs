using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	//Member Variables
	public enum MenuStates{MainMenu, Start, Settings};
	public MenuStates currentState;

	//Menu Panels
	public GameObject PanelMenu;
	public GameObject PanelStart;
	public GameObject PanelSettings;

	//Canvas
	public GameObject theCanvas;

	// Use this for initialization
	void Start () {		
	}

	//Sets Initial State to main menu
	void Awake(){		
		currentState = MenuStates.MainMenu;
	}

	// Update is called once per frame
	void Update () {

		//Updates MenuStates
		switch (currentState) {
		case MenuStates.MainMenu:
			PanelMenu.SetActive (true);
			PanelStart.SetActive (false);
			PanelSettings.SetActive (false);
			break;

		case MenuStates.Start:
			PanelMenu.gameObject.SetActive (false);
			PanelStart.SetActive (true);
			PanelSettings.SetActive (false);
			break;
		case MenuStates.Settings:
			PanelMenu.SetActive (false);
			PanelStart.SetActive (false);
			PanelSettings.SetActive (true);
			break;
		}	
	}

	//Back Button Press
	public void backPress(){		
		theCanvas.GetComponent<Canvas>().enabled = false;
	}
	//Adventure Button event
	public void adventurePress(){
		//SceneManager.LoadScene ("Town");
		//currentState = MenuStates.Town;
	}

	public void StartPress(){					
			currentState = MenuStates.Start;
			theCanvas.GetComponent<Canvas>().enabled = true;
	}

	public void playerPress(){
		SceneManager.LoadScene ("Town");
	}

	public void newHero(){
		bool Hero = false;

		if (Hero == false) {


		}

	}
}
