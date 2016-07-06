using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mediumSpecial : MonoBehaviour {



    public GameObject specialAmmo;
    public float damage = 3;
    public float bulletSpeed;
    public float bulletCount;

    float timer;
    float spread = 7;
    float specialTimer = 0.025f;
    public float timeBetweenSpecials;

    Vector3 gunPosition;

    public List<GameObject> justicePoints;
    List<GameObject> tempList = new List<GameObject>();

	// Use this for initialization
	void Start () {
        timer = timeBetweenSpecials;
    }

    IEnumerator StartSpecial() {
        timer = 0f;
        for(int i = 0; i < bulletCount; i++) {
            if (tempList.Count == 0) {
                tempList = new List<GameObject>(justicePoints);
            }

            int removeIndex = Random.Range(0, tempList.Count);
            gunPosition = tempList[removeIndex].transform.position;
            tempList.RemoveAt(removeIndex);

            Quaternion shootDirection = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(Random.Range(-spread, spread), 
                                                                                                      0,
                                                                                                      Random.Range(-spread, spread) )
                                                                                                      );
            GameObject bullet = Instantiate(specialAmmo, gunPosition, shootDirection) as GameObject;
            bullet bulletScript = bullet.GetComponent<bullet>();
            bulletScript.damage = damage;
            bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bulletSpeed * Random.Range(.8f, 1.2f), ForceMode.Impulse);
            yield return new WaitForSeconds(specialTimer); ;
        }

    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse1) && timer >= timeBetweenSpecials && Time.timeScale != 0) {
            Debug.Log("In get key");
            StartCoroutine("StartSpecial");
        }
    }
}
