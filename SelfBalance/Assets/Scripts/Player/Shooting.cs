using UnityEngine;

namespace CompleteProject
{
    public class Shooting : MonoBehaviour
    {



        float timer;   
		// A timer to determine when to fire.
        Ray shootRay;                                   // A ray from the gun end forwards.
        RaycastHit shootHit;                            // A raycast hit to get information about what was hit.
        int shootableMask;                              // A layer mask so the raycast only hits things on the shootable layer.
        ParticleSystem gunParticles;                    // Reference to the particle system.
        LineRenderer gunLine;                           // Reference to the line renderer.
        AudioSource gunAudio;                           // Reference to the audio source.
        Light gunLight;                                 // Reference to the light component.
		public Light faceLight;							
        float effectsDisplayTime = 0.2f;                // The proportion of the timeBetweenBullets that the effects will display for.

        public GameObject ammo;
		public GameObject gunpoint;
		Vector3 gunPosition;


		// These have to be changed for each class.
		float bulletSpeed = 50f;
		public int damagePerShot = 20;                   // The damage inflicted by each bullet.
		public float timeBetweenBullets = 2f;       	 // The time between each shot.
		public float range = 100f;                       // The distance the gun can fire.


        void Awake ()
        {
            
			// Create a layer mask for the Shootable layer.
            shootableMask = LayerMask.GetMask ("Shootable");
			gunPosition = gunpoint.transform.position;
			updateWeapon();
        }


        void Update ()
        {
            // Add the time since Update was last called to the timer.
            timer += Time.deltaTime;
			gunPosition = gunpoint.transform.position;

			if(Input.GetKey(KeyCode.Mouse0) && timer >= timeBetweenBullets && Time.timeScale != 0)
			{
				Shoot ();
			}

            // If the timer has exceeded the proportion of timeBetweenBullets that the effects should be displayed for...
            if(timer >= timeBetweenBullets * effectsDisplayTime)
            {
                // ... disable the effects.
                //DisableEffects (); Not implemented Yet
            }
        }

		void updateWeapon(){
			
		}

        void Shoot ()
        {
            // Reset the timer.
            timer = 0f;



			GameObject bullet = Instantiate(ammo, gunPosition, Quaternion.Euler(transform.rotation.eulerAngles)) as GameObject ;
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bulletSpeed * Random.Range(.8f,1.2f), ForceMode.Impulse);

			   
        }
    }
}

