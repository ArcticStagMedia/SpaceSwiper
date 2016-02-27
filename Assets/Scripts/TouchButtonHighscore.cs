using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TouchButtonHighscore : TouchButtonLogic
{

		void OnTouchUp ()
		{
		}

		void OnTouchDown ()
		{
				SceneManager.LoadScene ("HIGHSCORE");
		}
		
		
}
