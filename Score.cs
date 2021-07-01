using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public PlayerCollision playerCollision;
    // Start is called before the first frame update
    void Update(){
        ScoreText.text = playerCollision.returnNoOfTries().ToString();
    }
}
