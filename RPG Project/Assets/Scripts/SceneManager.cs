using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerr : MonoBehaviour {

	static SceneManagerr Instance;
	public Button AdventureButton;

	// Use this for initialization
	void Start () {
		if (Instance != null) {		
			GameObject.Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}
	
		Button btn = AdventureButton.GetComponent<Button>();
		btn.onClick.AddListener(loadAdventure);
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