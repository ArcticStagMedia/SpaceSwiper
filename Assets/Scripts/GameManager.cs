using UnityEngine;
using System;
using System.Collections;

public class GameManager : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{

		}

		public static void SpawnPoint (Vector2 startPos, string direction)
		{
				switch (direction) {
				case "right":
						Debug.Log (direction + startPos.ToString ());
						break;
				case "left":
						Debug.Log (direction + startPos.ToString ());
						break;
				case "up":
						Debug.Log (direction + startPos.ToString ());
						break;
				case "down":
						Debug.Log (direction + startPos.ToString ());
						break;
				}
		}
}
