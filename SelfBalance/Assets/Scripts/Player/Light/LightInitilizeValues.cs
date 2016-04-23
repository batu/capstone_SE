using UnityEngine;
using System.Collections;

public class LightInitilizeValues : MonoBehaviour {

    PlayerMovement MovementScript; 
    
    public float LightSpeed = 4f;
    // Use this for initialization
    void Start() {
        MovementScript = GetComponent<PlayerMovement>();
        MovementScript.speed = LightSpeed;

    }

    // Update is called once per frame
    void Update() {

    }
}
