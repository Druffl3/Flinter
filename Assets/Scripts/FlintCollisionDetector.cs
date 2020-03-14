using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlintCollisionDetector : MonoBehaviour
{
    public FlintMovementBehaviour flintMovement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            flintMovement.enabled = false;
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
