using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerScript gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Flint")
        {
            gameManager.CurrentLevelComplete();
        }
    }
}
