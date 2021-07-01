using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndLevelTriger : MonoBehaviour
{
    public GameManager gameManager; 
    
    void OnTriggerEnter(){
        gameManager.CompleteLevel(); 
        //ScoreText.text = playerCollision.returnNoOfTries().ToString();
    }
}
