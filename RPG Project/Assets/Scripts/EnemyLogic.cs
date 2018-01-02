using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour {
	public int enemyHealth;
	public int enemyStamina;

	// Use this for initialization
	void Start () {
		enemyHealth = 0;
		enemyStamina = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Enemy(int eHealth, int eStam){
		eHealth = enemyHealth;
		eStam = enemyStamina;
	}

	public int enemyAttack(int dmg){
		dmg = 50;
		return dmg;
	}
}
