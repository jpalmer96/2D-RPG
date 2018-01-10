using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	//Stats
	public string playerName;
	public int health;
	public int mana;

	//Attributes
	//public int strength;

	// Use this for initialization
	void Start () {
		playerName = "CatDog";
		health = 100;
		mana = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Getters
	public string getName(){
		return playerName;
	}
	public int getHealth(){
		return health;
	}
		
	public int getMana(){
		return mana;
	}

	//Mutators
	public void setName(string name){
		playerName = name;
	}
	public void setHealth(int hp){
		health = hp;
	}

	public void setMana(int mp){
		mana = mp;
	}

}
