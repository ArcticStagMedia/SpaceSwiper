using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuButtons : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{
				
		}

		public void PlayBTN ()
		{
				SceneManager.LoadScene ("PlayGameScene");
		}

		public void HighscoreBTN ()
		{
				SceneManager.LoadScene ("HighScoreScene");
		}

		public void OptionsBTN ()
		{
				SceneManager.LoadScene ("OptionsScene");
		}
}
