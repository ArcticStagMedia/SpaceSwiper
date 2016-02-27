using UnityEngine;
using System.Collections;

public class HorizexController : MonoBehaviour
{

		// Private Variable declaration
		private const string healthTag = "Health";
		private const string enemyTag = "Enemy";
		private const string projectileTag = "Projectile";


		// Public variable declaration
		public Collider2D deathCollider;
		public Collider2D[] blockerCollider;

		void OnTriggerEnter2D (Collider2D other)
		{
				// If object hit not health object or other enemy
				if (other.tag != healthTag || other.tag != enemyTag) {
						if (other == deathCollider) {
								if (CheckProjectile (other.tag)) {
										//Do death thing
										Debug.Log ("Die");
								}
						} else if (other == blockerCollider [0] || other == blockerCollider [1]) {
								if (CheckProjectile (other.tag)) {
										// Do blocker thing
										Debug.Log ("Block");
								}
						} else {
								Debug.LogError (other.name + " didnt hit anything???");
						}
				}
		}

		bool CheckProjectile (string tag)
		{
				if (tag == projectileTag) {
						return true;
				} else {
						return false;
				}
		}
}
