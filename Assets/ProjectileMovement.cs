using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour
{
	
		// Private variable declaraton
		private Rigidbody2D rgdbdy;

		// Public variable declaration
		public float movementSpeed = 5f;

		// Start is called once only
		void Start ()
		{
				rgdbdy = gameObject.GetComponent<Rigidbody2D> ();
		}

		// Update is called once per frame
		void Update ()
		{
				Move ();
		}

		void Move ()
		{
				rgdbdy.transform.Translate (Vector3.up * movementSpeed * Time.deltaTime);	
		}
}
