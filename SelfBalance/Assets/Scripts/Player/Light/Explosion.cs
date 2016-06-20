using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	float startTime;
	public float lifeTime; 

	public GameObject explosion;
	public GameObject explosion2;
	public GameObject[] damageable;

	float explosionRange = 20;
	float explosionDamage = 30;
	float explosionForce = 3f;

	PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		damageable = GameObject.FindGameObjectsWithTag("Player");

	}



	void EXPLODE(){
		foreach (GameObject player in damageable){

            float distance = Vector3.Distance(player.transform.position, transform.position);
            Debug.Log("Printing distance and player name: " + distance + "/" + explosionRange + " " + player.name);
            if (distance  < explosionRange){
                Debug.Log("I am in if.");
				playerHealth = player.GetComponent<PlayerHealth>();
                Debug.Log(player.name + " health is: " + playerHealth.current_health);
				playerHealth.current_health = playerHealth.current_health - explosionDamage;
                Debug.Log(player.name + " health went down to: " + playerHealth.current_health);
            }
			Rigidbody rb = player.GetComponent<Rigidbody>();

			if (rb != null){
				rb.AddExplosionForce(explosionForce, transform.position, explosionRange, 3.0F);
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
			Instantiate(explosion2, new Vector3(gameObject.transform.position.x,
				gameObject.transform.position.y,
				gameObject.transform.position.z), Quaternion.identity);
			Destroy(gameObject);

		}
	}
}
