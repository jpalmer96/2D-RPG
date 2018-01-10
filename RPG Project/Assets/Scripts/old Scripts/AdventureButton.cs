using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdventureButton : MonoBehaviour {

		public Button AdvButton;

		// Use this for initialization
		void Start () {
			
			Button btn = AdvButton.GetComponent<Button>();
			btn.onClick.AddListener(adventurePress);
		}

		// Update is called once per frame
		void Update () {
			
		}
			
		public void adventurePress(){
		//Scene thisScene = SceneManager.GetActiveScene();
			
			SceneManager.LoadScene ("Adventure");
			//SceneManager.UnloadSceneAsync (thisScene);	
			//SceneManager.SetActiveScene ("Adventure");
		}		
	}
