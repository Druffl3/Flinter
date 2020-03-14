using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;
    public float RestartDelay = 0.5f;
    public GameObject levelCompleteUI;

    public void CurrentLevelComplete()
    {
        levelCompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("RestartGame",RestartDelay);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
