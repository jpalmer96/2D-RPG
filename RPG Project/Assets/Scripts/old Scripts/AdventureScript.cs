using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//EnemyLogic eLogic = new EnemyLogic ();
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown(0))
		//}
		}

	public void rollScenerio(){
		int scenNumber = Random.Range (0,10);
			
		if (scenNumber < 4) {
			//Generate enemy
			//eLogic.enemy ();

		} else if (scenNumber < 8 && scenNumber >= 4) {
			Debug.Log("Treasure!");
		} else {
			Debug.Log("random!");
		}
	}
}

