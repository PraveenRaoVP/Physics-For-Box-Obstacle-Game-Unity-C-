using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce=750f;
    public float sidewaysForce = 57.08f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate(){
        if(Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(0,0,forwardForce*Time.deltaTime);
        }
        if(Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce(0,0,-forwardForce*Time.deltaTime);
        }
        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }

}
