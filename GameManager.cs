using UnityEngine;
//using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 defaultPlayerPos;
    Quaternion defaultBallRot;
    public Transform player;    
    public PlayerMovement movement;
    public GameObject completeLevelUI;
    
    void Start()
    {
        defaultPlayerPos = player.transform.position;
        defaultBallRot = player.transform.rotation;
    }

    // Update is called once per frame
    void Update(){
        
    }
    public void restart(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.transform.position = defaultPlayerPos;
        player.transform.rotation = defaultBallRot;
        movement.enabled=true;
        
    }

    public void CompleteLevel(){
        Debug.Log("Level Complete");
        
        completeLevelUI.SetActive(true);
    }
}
