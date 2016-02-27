using UnityEngine;
using System.Collections;

public class testFire : MonoBehaviour
{

		// Private variable declaration
		private const float maxCoolDown = 1.5f;
		private float coolDownTimer = 0;

		// Public variable declaration
		public GameObject projectile;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				Fire ();
				CoolDown ();
		}

		void Fire ()
		{
				if (Input.GetKeyDown (KeyCode.Mouse0) && coolDownTimer == 0) {
						Vector3 spawnLocation = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, -50));
						spawnLocation.z = 0;
						GameObject clone = Instantiate (projectile, spawnLocation, Quaternion.identity) as GameObject;
						coolDownTimer = maxCoolDown;
				}	
		}

		void CoolDown ()
		{
				Debug.Log (coolDownTimer);
				if (coolDownTimer > 0) {
						coolDownTimer = coolDownTimer - Time.deltaTime;
						return;
				} else if (coolDownTimer == 0) {
						return;
				} else if (coolDownTimer < 0) {
						coolDownTimer = 0;
						return;
				}
						
		}
}
