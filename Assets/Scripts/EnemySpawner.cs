using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
		//Private variable declaration
		private Camera mainCamera;
		private int screenWidthMax;
		private int screenHeightMax;
		private int screenWidthMin = -15;
		private int screenHeightMin = -100;
		private bool spawn = true;

		//Public variable declaration
		public GameObject[] enemies;
		public float maxSpawnWait = 5f;


		// Use this for initialization
		void Start ()
		{
				// Initialization of variables
				mainCamera = Camera.main;
				screenWidthMax = Screen.width + 15;
				screenHeightMax = Screen.height;

				StartCoroutine ("SpawnWave");
		}
	
		// Update is called once per frame
		void Update ()
		{

		}

		Vector3 RandomSpawn ()
		{
				int randomSelection = Random.Range (0, 2);
				Vector3 temp;

				switch (randomSelection) {
				case 0:
						// Random Spawn Left
						temp = mainCamera.ScreenToWorldPoint (new Vector3 (screenWidthMin, Random.Range (0, screenHeightMax), 0));
						temp.z = 0;
						return temp;
						break;
				case 1:
						// Random Spawn Right
						temp = mainCamera.ScreenToWorldPoint (new Vector3 (screenWidthMax, Random.Range (0, screenHeightMax), 0));
						temp.z = 0;
						return temp;
						break;
				default:
						// Fatal error catch
						Debug.LogError (randomSelection + " is not a valid argument");
						return Vector3.zero;
						break;
				}
		}

		IEnumerator SpawnWave ()
		{
				while (spawn) {
						for (int i = 0; i < 10; i++) {
								int selection = Random.Range (0, enemies.Length);
								GameObject clone = Instantiate (enemies [selection], RandomSpawn (), Quaternion.identity) as GameObject;
								clone.gameObject.GetComponent<EnemyMovement> ().moveSpeed = Random.Range (4, 10);
								clone.name = "Enemy";
								yield return new WaitForSeconds (Random.Range (0, maxSpawnWait));
						}
				}	
		}
}
