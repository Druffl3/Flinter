using UnityEngine;
using UnityEngine.SceneManagement;
public class FlintMovementBehaviour : MonoBehaviour
{
    public Rigidbody flintBody;
    public float MovementSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        flintBody.AddForce(0, 0, MovementSpeed * Time.deltaTime);
        if (Input.GetKey("d"))
            flintBody.AddForce(MovementSpeed * Time.deltaTime, 0, 0);
        else if (Input.GetKey("a"))
            flintBody.AddForce(-MovementSpeed * Time.deltaTime, 0, 0);
        else if (flintBody.position.y < -1f)
            FindObjectOfType<GameManagerScript>().EndGame();
    }
}
