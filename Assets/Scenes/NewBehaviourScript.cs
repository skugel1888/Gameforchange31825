using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator playerAnim;


    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    public Rigidbody Myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if(Input.GetKeyDown(KeyCode.Space))
            {
         

             Myrigidbody.linearVelocity = Vector3.up *5;
            }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Myrigidbody.linearVelocity = Vector3.left*3;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Myrigidbody.linearVelocity = Vector3.right * 3;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Myrigidbody.linearVelocity = Vector3.back * 3;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Myrigidbody.linearVelocity = Vector3.forward * 3;
        }
    


    }
    void MovePlayerRelativeToCamera()
    {
        float playerVerticalInput = Input.GetAxis("Vertical");
        float playerHorizontalInput = Input.GetAxis("Horizontal");
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;
        forward.y = 0;
        right.y = 0;
        forward = forward.normalized; 
        right = right.normalized;

        Vector3 forwardRelativeVerticalInput = playerVerticalInput * forward;
        Vector3 rightRelativeHorizontalInput = playerHorizontalInput * right;
        Vector3 cameraRelativeMovement = forwardRelativeVerticalInput + rightRelativeHorizontalInput;
        this.transform.Translate(cameraRelativeMovement, Space.World);
    
    }
}
