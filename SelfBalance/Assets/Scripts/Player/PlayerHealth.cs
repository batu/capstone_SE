using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {


	public float max_health = 100;

	[HideInInspector]
	public float current_health;

	// Use this for initialization
	void Start () {
		current_health = max_health;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){

		if(col.collider.tag == "bullet"){
			//col.collider.GetComponent();
			
		}

	}
}
