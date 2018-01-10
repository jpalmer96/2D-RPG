using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	//Player
	public PlayerScript player;
	//Scripts
	//PlayerScript player;

	//Member Variables
	public enum MenuStates{Adventure, Hero, Inn};
	public MenuStates currentState;

	//Menu Panels
	public GameObject AdventurePanel;
	public GameObject HeroPanel;
	public GameObject InnPanel;
	//Canvas
	public GameObject theCanvas;
	//Text Objects
	public Text playerNameText;
	public Text heroHealthText;
	public Text heroManaText;


	//Sets menus initially false
	void Awake(){			
		theCanvas.GetComponent<Canvas>().enabled = false;
	}

	// Use this for initialization
	void Start () {	
		playerNameText.text = player.getName();
		heroHealthText.text = "HP: " + player.getHealth();
		heroManaText.text = "MP: " + player.getMana();
		//Debug.Log (heroHealthText.text);
	}



	// Update is called once per frame
	void Update () {

		//Updates MenuStates
		switch (currentState) {
		case MenuStates.Adventure:			
			HeroPanel.SetActive (false);
			InnPanel.SetActive (false);
			AdventurePanel.SetActive (true);
			break;

		case MenuStates.Hero:
			AdventurePanel.SetActive (false);
			InnPanel.SetActive (false);
			HeroPanel.SetActive (true);
			break;
		case MenuStates.Inn:			
			AdventurePanel.SetActive (false);
			HeroPanel.SetActive (false);
			InnPanel.SetActive (true);
			break;
		}

		//Raycast for mouse click
		if (Input.GetMouseButtonDown (0)) {
			//Debug.Log ("Clicked");
			Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
			// RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
				if(hitInfo)
				{
					//Debug.Log( hitInfo.transform.gameObject.name );
					// Here you can check hitInfo to see which collider has been hit, and act appropriately.
					
				//Clicked Tree
						if(hitInfo.transform.gameObject.name == "Tree"){
							Debug.Log( hitInfo.transform.gameObject.name );
							currentState = MenuStates.Adventure;
							theCanvas.GetComponent<Canvas>().enabled = true;		
											
						
				//Clicked Stump
						}else if(hitInfo.transform.gameObject.name == "Stump"){
							Debug.Log( hitInfo.transform.gameObject.name );													
							currentState = MenuStates.Hero;
							theCanvas.GetComponent<Canvas>().enabled = true;
							
											
						}//Clicked Inn
						else if(hitInfo.transform.gameObject.name == "Inn"){
							Debug.Log( hitInfo.transform.gameObject.name );													
							currentState = MenuStates.Inn;
							theCanvas.GetComponent<Canvas>().enabled = true;
						}
						//Error Catching
						else{
								Debug.Log("You messed up!");
							}
					}
		}
	}
	//<-- End Update -->


	//Back Button Press
	public void backPress(){		
		theCanvas.GetComponent<Canvas>().enabled = false;
	}
	//Adventure Button event
	public void adventurePress(){
		SceneManager.LoadScene ("Adventure");
		currentState = MenuStates.Adventure;
	}
		
	public void restPress(){
		
	}
}
