using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class SwipeController : MonoBehaviour
{

		Vector2 initTouchPos;
		public Text debugText;

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{
				int fingerCount = 0;

				foreach (Touch touch in Input.touches) {
						if (touch.phase == TouchPhase.Began) {
								initTouchPos = touch.position;
						}

						if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
								fingerCount++;

								if (fingerCount == 1 && touch.phase == TouchPhase.Began) {
										Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
										RaycastHit hit;

										if (Physics.Raycast (ray, out hit)) {
												if (hit.transform.tag == "ButtonPush" || hit.transform.tag == "ButtonPadAbove" || hit.transform.tag == "ButtonPadBelow" || hit.transform.tag == "ButtonShield") {
														//hit.collider.GetComponent<ButtonScript> ().Pressed ();
												}
										}
								}

								if (fingerCount == 1 && touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Ended) {
										Vector2 touchFacing = (initTouchPos - touch.position).normalized;

										if (Vector2.Dot (touchFacing, Vector2.up) > 0.8 && Vector2.Distance (initTouchPos, touch.position) > 20) {
												Ability ("SwipeDown", initTouchPos);
										}
										if (Vector2.Dot (touchFacing, -Vector2.up) > 0.8 && Vector2.Distance (initTouchPos, touch.position) > 20) {
												Ability ("SwipeUp", initTouchPos);
										}
										if (Vector2.Dot (touchFacing, Vector2.right) > 0.8 && Vector2.Distance (initTouchPos, touch.position) > 20) {
												Ability ("SwipeLeft", initTouchPos);
										}
										if (Vector2.Dot (touchFacing, -Vector2.right) > 0.8 && Vector2.Distance (initTouchPos, touch.position) > 20) {
												Ability ("SwipeRight", initTouchPos);
										}
								}
						}
				}
		}

		void Ability (string swipeType, Vector2 startPoint)
		{
				switch (swipeType) {

				case "SwipeUp":
						{

								Debug.Log ("up");
								GameManager.SpawnPoint (startPoint.normalized, "up");
								break;
						}
				case "SwipeDown":
						{

								Debug.Log ("down");
								GameManager.SpawnPoint (startPoint.normalized, "down");
								break;
						}
				case "SwipeLeft":
						{

								Debug.Log ("left");
								GameManager.SpawnPoint (startPoint.normalized, "left");
								break;
						}
				case "SwipeRight":
						{

								Debug.Log ("right");
								GameManager.SpawnPoint (startPoint.normalized, "right");
								break;
						}
				default:
						{
								Debug.Log ("Ability string not found");
								break;
						}

				}
		}
}