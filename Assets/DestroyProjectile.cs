using UnityEngine;
using System.Collections;

public class DestroyProjectile : MonoBehaviour
{

		// Private variablae declaration
		private const string projectileTag = "Projectile";

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{

		}

		void OnTriggerEnter2D (Collider2D other)
		{
				switch (other.tag) {
				case projectileTag:
						Destroy (other.gameObject);
						break;
				default:
						Debug.Log (other.name + " is not tagged enemy");
						break;
				}
		}
}
