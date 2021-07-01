using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public Rigidbody player;
    public PlayerMovement movement;
    public PlayerCollision collision;

    public void OnButtonPress(){
        movement.enabled=false;
        player.velocity=Vector3.zero;
        player.angularVelocity=Vector3.zero;
        gameManager.Invoke("restart",0.5f);
        collision.noOfTries = 0;
    }
}
