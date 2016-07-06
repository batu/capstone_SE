using UnityEngine;
using System.Collections;

public class SpecialAttack : MonoBehaviour {


	float timer;   
	public float timeBetweenSpecials = 2f;

	// Either a wall or a bomb
	public GameObject special;

	public GameObject spawnPoint;
	Vector3 spawnPosition;


	// Use this for initialization
	void Start () {
		spawnPosition = spawnPoint.transform.position;
	}


	void SpawnSpecial(){
		// Reset the timer.
		timer = 0f;

		Instantiate(special, spawnPosition, Quaternion.Euler(transform.rotation.eulerAngles));


	}

	// Update is called once per frame
	void Update () {
		spawnPosition = spawnPoint.transform.position;

		timer += Time.deltaTime;
		if(Input.GetKey(KeyCode.Mouse1) && timer >= timeBetweenSpecials && Time.timeScale != 0){
			SpawnSpecial();
		}
	}
}
