using UnityEngine;
using System.Collections;

public class MediumInitilizeValues : MonoBehaviour {

    PlayerMovement movementScript;
    PlayerHealth healthScript;
    Shooting shootingScript;
    //mShooting shootingScript;
    bullet bulletScript;
    SpecialAttack speacialAttackScript;

    //Active Player
    bool isPlayer;


    //Shooting variables;
    float mBulletSpeed = 120f;
    float mDamagePerShot = 15f;
    float mTimeBetweenBullets = 0.4f;
    float mAmmoSize = 1f;


    //health variables
    float mMaxHealth = 110f;
    float mSpeed = 8f;

    // special attack 
    float mTimeBetweenSpecials = 2f;

    // Use this for initialization
    void Awake() {
        movementScript = GetComponent<PlayerMovement>();
        healthScript = GetComponent<PlayerHealth>();
       	shootingScript =  GetComponent<Shooting>();
        //shootingScript = GetComponent<mShooting>();
        speacialAttackScript = GetComponent<SpecialAttack>();


        movementScript.speed = mSpeed;

        initilizeShooting();
        initilizeHealth();
    }

    void initilizeHealth() {
        healthScript.max_health = mMaxHealth;
    }

    void initilizeShooting() {
        shootingScript.bulletSpeed = mBulletSpeed;
        shootingScript.timeBetweenBullets = mTimeBetweenBullets;
        shootingScript.ammoScale = mAmmoSize;
        shootingScript.damage = mDamagePerShot;

    }

    void initilizeSpecial() {
        speacialAttackScript.timeBetweenSpecials = mTimeBetweenSpecials;
    }

    // Update is called once per frame
    void Update() {
        initilizeShooting();
        initilizeHealth();
    }
}
