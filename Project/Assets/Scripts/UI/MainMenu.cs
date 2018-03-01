﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private void OnEnable()
    {
        GameManager.gameManager.Load();
    }

    public void PlayGame() {

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame() {

		Debug.Log ("QUIT");
        GameManager.gameManager.Save();
		Application.Quit ();
	}
}
