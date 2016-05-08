using UnityEngine;
using System.Collections;

public class HeavyInitilizeValues : MonoBehaviour {

    PlayerMovement movementScript;
	PlayerHealth healthScript;
	Shooting shootingScript;
	bullet bulletScript;
	SpecialAttack speacialAttackScript;

	//Shooting variables;
	float hBulletSpeed = 75f;
	float hDamagePerShot = 20;
	float hTimeBetweenBullets = 1f;
	float hAmmoSize = 2f;


	//health variables
	float hMaxHealth = 125f;
    float hSpeed = 4f;

	// special attack 
	float hTimeBetweenSpecials = 20f;

	void Awake(){
		movementScript = GetComponent<PlayerMovement>();
		healthScript =  GetComponent<PlayerHealth>();
		shootingScript =  GetComponent<Shooting>();
		speacialAttackScript =  GetComponent<SpecialAttack>();


		movementScript.speed = hSpeed;

		initilizeShooting();
		initilizeHealth();
	}

	void initilizeSpecial(){
		speacialAttackScript.timeBetweenSpecials = hTimeBetweenSpecials;
	}


	void initilizeHealth(){
		healthScript.max_health = hMaxHealth;
	}

	void initilizeShooting(){
		shootingScript.bulletSpeed = hBulletSpeed;
		shootingScript.timeBetweenBullets = hTimeBetweenBullets;       

		shootingScript.ammoScale = hAmmoSize;
		shootingScript.damage = hDamagePerShot;  

	}

    // Update is called once per frame
    void Update() {
		initilizeShooting();
		initilizeHealth();
    }
}
