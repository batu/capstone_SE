using UnityEngine;
using UnityEngine.UI;
using Photon;
using System.Collections;

public class MCharSelect : Photon.PunBehaviour {

    public Canvas CharSelectCanvas;
    public Button heavySelect;
    public Button lightSelect;

    public GameObject SpawnPoint, EnemySpawnPoint;
    public GameObject Light, Heavy;
    //public GameObject LightAI, HeavyAI;

    public void mLightSelected() {
        CharSelectCanvas.enabled = false;
        GameObject light = PhotonNetwork.Instantiate("mLight", SpawnPoint.transform.position, SpawnPoint.transform.rotation, 0);

        PlayerMovement movementController = light.GetComponent<PlayerMovement>();
        movementController.enabled = true;

        mShooting shootingController = light.GetComponent<mShooting>();
        shootingController.enabled = true;


        //Instantiate(HeavyAI, EnemySpawnPoint.transform.position, EnemySpawnPoint.transform.rotation);
    }

    public void mHeavySelected() {
        CharSelectCanvas.enabled = false;
        GameObject heavy = PhotonNetwork.Instantiate("mHeavy", SpawnPoint.transform.position, SpawnPoint.transform.rotation, 0);


        PlayerMovement movementController = heavy.GetComponent<PlayerMovement>();
        movementController.enabled = true;

        mShooting shootingController = heavy.GetComponent<mShooting>();
        shootingController.enabled = true;

        //Instantiate(LightAI, EnemySpawnPoint.transform.position, EnemySpawnPoint.transform.rotation);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
