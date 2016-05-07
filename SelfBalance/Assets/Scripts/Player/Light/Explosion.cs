using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	float startTime;
	public float lifeTime; 

	public GameObject explosion;
	public GameObject[] damageable;
	public float explosionRange = 5f;
	public float explosionDamage = 20f;

	PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		damageable = GameObject.FindGameObjectsWithTag("Player");

	}


	void EXPLODE(){
		foreach (GameObject player in damageable){
			if(Vector3.Distance(player.transform.position, transform.position) < explosionRange){
				Debug.Log("HIT!");
				//playerHealth = player.GetComponent<PlayerHealth>();
				//playerHealth.current_health = playerHealth.current_health - explosionDamage;
			
			}
		}
		
	}
	// Update is called once per frame
	void Update () {
		if(Time.time - startTime > lifeTime){
			EXPLODE();
			Instantiate(explosion, new Vector3(gameObject.transform.position.x,
				gameObject.transform.position.y,
				gameObject.transform.position.z), Quaternion.identity);
			Destroy(gameObject);

		}
	}
}
