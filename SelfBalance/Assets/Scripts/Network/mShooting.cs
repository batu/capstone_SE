using UnityEngine;


public class mShooting : MonoBehaviour{

	[HideInInspector]
	public bullet bulletScript;

    float timer;   
	// A timer to determine when to fire.

    int shootableMask;                              // A layer mask so the raycast only hits things on the shootable layer.

    public GameObject ammo;
	public GameObject gunpoint;
	Vector3 gunPosition;


	// These have to be changed for each class.
	public float ammoScale = 1f;
	public float damage = 10f;
	public float bulletSpeed = 50f;                 // The damage inflicted by each bullet.
	public float timeBetweenBullets = 2f;       	 // The time between each shot.

    void Start ()
    {
		bulletScript = GetComponent<bullet>();
        shootableMask = LayerMask.GetMask ("Shootable");
		gunPosition = gunpoint.transform.position;
    }


    void Update ()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;
		gunPosition = gunpoint.transform.position;

		if(Input.GetKey(KeyCode.Mouse0) && timer >= timeBetweenBullets && Time.timeScale != 0){
			Shoot ();
		}
			
    }
		

    void Shoot ()
    {
        // Reset the timer.
        timer = 0f;
		GameObject bullet = PhotonNetwork.Instantiate("mAmmo", gunPosition, Quaternion.Euler(transform.rotation.eulerAngles), 0) as GameObject;
		bullet bulletScript = bullet.GetComponent<bullet>();
		bulletScript.ammoScale = ammoScale;
		bulletScript.damage = damage;
		bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bulletSpeed * Random.Range(.8f,1.2f), ForceMode.Impulse);

		   
    }
}


