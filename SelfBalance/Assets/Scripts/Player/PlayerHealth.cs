using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {


	public float max_health = 100;
	bullet bulletScript;

	[HideInInspector]
	public float current_health;

	// Use this for initialization
	void Start () {
		current_health = max_health;
	}
	
	// Update is called once per frame
	void Update () {
		if(current_health < 0){
			Destroy(gameObject);
		}
	
	}

	void OnCollisionEnter(Collision col){

		if(col.collider.tag == "bullet"){
			float damage;
			bulletScript = col.collider.gameObject.GetComponent<bullet>();
			damage = bulletScript.damage;
			current_health = current_health - damage;
			Debug.Log(gameObject.name + " has been dealt " + damage + " damage.");
		}

	}
}
