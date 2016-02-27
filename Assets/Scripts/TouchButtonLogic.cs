using UnityEngine;
using System.Collections;

public class TouchButtonLogic : MonoBehaviour
{	
		void Update ()
		{
				//check to see is there a touch on screen
				if (Input.touches.Length <= 0) {
						//If no touches
						//Do this
				} else {
						//all touches on screen
			
						//loop all touches
						for (int i = 0; i<Input.touchCount; i++) {
								//execute code for touch on screen (i)
								if (this.GetComponent<GUITexture>() != null && (this.GetComponent<GUITexture>().HitTest (Input.GetTouch (i).position))) {
										//if current touch hits guiTexture
										if (Input.GetTouch (i).phase == TouchPhase.Began) {
												//sending the message to get a touch down
												SendMessage ("OnTouchDown", SendMessageOptions.DontRequireReceiver);
										}
										if (Input.GetTouch (i).phase == TouchPhase.Ended) {
												//sending the message that the toush ended
												SendMessage ("OnTouchUp", SendMessageOptions.DontRequireReceiver);
										}
								}
						}
				}
		}
}
