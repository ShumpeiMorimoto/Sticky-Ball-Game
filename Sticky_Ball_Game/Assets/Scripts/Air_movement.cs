using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air_movement : MonoBehaviour
{
    bool IsGrounded;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "ground"){
            IsGrounded = true;
            rb.mass = 1;
            Debug.Log("Ground");
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            IsGrounded = false;
            rb.mass += 50;
            Debug.Log("Air");
        }
    }

    void OnCollisonEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            IsGrounded = true;
            rb.mass = 1;
            Debug.Log("Ground");
        }
        if (other.gameObject.tag == "item")
        {
            IsGrounded = true;
            rb.mass = 1;
            Debug.Log("Ground");
        }
    }


}
