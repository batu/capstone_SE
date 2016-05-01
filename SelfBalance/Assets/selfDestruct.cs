using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {

	float startTime;
	public float lifeTime = 3f;


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
}
