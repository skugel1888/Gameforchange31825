using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private bool jumpkeywaspressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpkeywaspressed = true;
        }
    }
   //Fixed update happens every physics update which happens 100 times every second.
    private void FixedUpdate()
    {
        if (jumpkeywaspressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*5, ForceMode.VelocityChange);
            jumpkeywaspressed = false;
        }
    }
}
