using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float restartDelay;

    public GameObject levelCompleteUI;

    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
    }

	public void GameOver()
    {
        Invoke("Restart", restartDelay);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
