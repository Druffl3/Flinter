using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    public Transform Flint;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Flint.position.z.ToString("0");
    }
}
