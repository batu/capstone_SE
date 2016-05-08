using UnityEngine;
using System.Collections;

public class LightInitilizeValues : MonoBehaviour {

	PlayerMovement movementScript;
	PlayerHealth healthScript;
	Shooting shootingScript;
	bullet bulletScript;
	SpecialAttack speacialAttackScript;

	//Shooting variables;
	float lBulletSpeed = 100f;
	float lDamagePerShot = 10f;
	float lTimeBetweenBullets = 0.25f;
	float lAmmoSize = .75f;


	//health variables
	float lMaxHealth = 90;
	float lSpeed = 10f;

	// special attack 
	float lTimeBetweenSpecials = 5f;

	// Use this for initialization
	void Awake() {
		movementScript = GetComponent<PlayerMovement>();
		healthScript =  GetComponent<PlayerHealth>();
		shootingScript =  GetComponent<Shooting>();
		speacialAttackScript =  GetComponent<SpecialAttack>();


		movementScript.speed = lSpeed;

		initilizeShooting();
		initilizeHealth();
	}

	void initilizeHealth(){
		healthScript.max_health = lMaxHealth;
	}

	void initilizeShooting(){
		shootingScript.bulletSpeed = lBulletSpeed;
		shootingScript.timeBetweenBullets = lTimeBetweenBullets;       
		shootingScript.ammoScale = lAmmoSize;
		shootingScript.damage = lDamagePerShot;  

	}

	void initilizeSpecial(){
		speacialAttackScript.timeBetweenSpecials = lTimeBetweenSpecials;
	}

	// Update is called once per frame
	void Update() {
		initilizeShooting();
		initilizeHealth();
	}
}
