using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour
{
    public void ExitAction()
    {
        Application.Quit();
    }

    public void ReplayAction()
    {
        SceneManager.LoadScene(1); //Loads from the first level.
    }
}
