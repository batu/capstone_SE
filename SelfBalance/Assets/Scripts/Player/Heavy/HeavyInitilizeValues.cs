using UnityEngine;
using System.Collections;

public class HeavyInitilizeValues : MonoBehaviour {

    PlayerMovement movementScript;
    public float HeavySpeed = 4f;
    // Use this for initialization
    void Start() {
        movementScript = GetComponent<PlayerMovement>();
        movementScript.speed = HeavySpeed;

    }

    // Update is called once per frame
    void Update() {

    }
}
