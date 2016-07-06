using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharSelect : MonoBehaviour {

    public Canvas CharSelectCanvas;
    public Button heavySelect;
    public Button lightSelect;

    public GameObject SpawnPoint, EnemySpawnPoint;
    public GameObject Light, Heavy;
    public GameObject LightAI, HeavyAI;

    public void LightSelected() {
        CharSelectCanvas.enabled = false;
        Instantiate(Light, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        Instantiate(HeavyAI, EnemySpawnPoint.transform.position, EnemySpawnPoint.transform.rotation);
    }

    public void HeavySelected() {
        CharSelectCanvas.enabled = false;
        Instantiate(Heavy, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        Instantiate(LightAI, EnemySpawnPoint.transform.position, EnemySpawnPoint.transform.rotation);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
