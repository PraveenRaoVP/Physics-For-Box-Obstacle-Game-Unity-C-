using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    public int noOfTries;
    public Transform Ground;
    public GameManager gameManager;
    public PlayerMovement movement;

     void start() => noOfTries = 0; 

     void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacles"
               || collisionInfo.collider.tag == "SideWalls"){
            noOfTries++;
            //gameManager.restart();
            player.velocity=Vector3.zero;
            player.angularVelocity=Vector3.zero;
            
            GetComponent<PlayerMovement>().enabled=false;
            gameManager.Invoke("restart",0.5f);
            
        }
        else if (collisionInfo.collider.tag=="Underground"){
            noOfTries++;
            //gameManager.restart();
            player.velocity=Vector3.zero;
            player.angularVelocity=Vector3.zero;
            
            GetComponent<PlayerMovement>().enabled=false;
            gameManager.Invoke("restart",0f);
        }
    }
    /*void isInAir(Collision collisionInfo){
        if(GetComponent<Collider>()==null){
            Debug.Log("We are in the air");
            movement.enabled=false;
        }
        else{
            movement.enabled=true;
        }

    }*/

     public int returnNoOfTries() => noOfTries;
}
