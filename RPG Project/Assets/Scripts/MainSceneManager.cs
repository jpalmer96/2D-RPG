using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour {

	static MainSceneManager Instance;
		public Button AdventureButton;

		// Use this for initialization
		void Start () {
			if (Instance != null) {		
				GameObject.Destroy (gameObject);
			} else {
				GameObject.DontDestroyOnLoad (gameObject);
				Instance = this;
			}					
		}

		// Update is called once per frame
		void Update () {
		}

		public void loadTown(){
			SceneManager.LoadScene ("Town");
		}
		public void loadAdventure(){
			SceneManager.LoadScene ("Adventure");
		}
	}