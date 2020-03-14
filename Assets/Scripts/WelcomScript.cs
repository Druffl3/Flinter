using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomScript : MonoBehaviour
{
    public void StartAction()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitAction()
    {
        Application.Quit();
    }
}
