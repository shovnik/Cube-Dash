﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
