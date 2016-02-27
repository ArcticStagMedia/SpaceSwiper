using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
		// Private variable declaration
		private string Direction = "Left";

		//Public variable declaration
		public float moveSpeed = 10.0f;
		public Rigidbody2D rgdbdy;

		void Start ()
		{
				// If Rigidbody2D not set, set to this game objects Rigidbody2D
				if (rgdbdy == null) {
						rgdbdy = gameObject.GetComponent<Rigidbody2D> ();
				}
				//Set direction to travel via current position
				if (gameObject.transform.position.x < 0) {
						Direction = "Right";
						Debug.Log ("Direction set to " + Direction);
				} else if (gameObject.transform.position.x > 0) {
						Direction = "Left";
						Debug.Log ("Direction set to " + Direction);
				}
		}

		void Update ()
		{
				// Move game object
				Move (Direction);
		}

		void Move (string direction)
		{
				// Select direction to move bassed on variable given
				switch (direction) {
				case "Right":
						rgdbdy.transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
						break;
				case "Left":
						rgdbdy.transform.Translate (Vector3.right * -1 * moveSpeed * Time.deltaTime);
						break;
				default:
						// Fatal error catch
						Debug.LogError (direction + " is not a valid option for this action!");
						break;
				}
		}
}
