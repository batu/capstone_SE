using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	float startTime;
	public float lifeTime = 3f;

	public GameObject explosion;



	float bulletSpeed;


	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - startTime > lifeTime){
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision col){

		Destroy(gameObject);
		Instantiate(explosion, new Vector3(gameObject.transform.position.x,
			gameObject.transform.position.y,
			gameObject.transform.position.z), Quaternion.identity);
	}
}
