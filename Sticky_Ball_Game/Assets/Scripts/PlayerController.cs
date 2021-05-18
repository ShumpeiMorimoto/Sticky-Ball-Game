using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    public Vector3 MoveVector;
    public float moveHorizontal;
    public float moveVertical;
    public float moveForceMultiplier;

    private Rigidbody rb;
    private Transform camTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveVector = PoolInput();       
        MoveVector = RotateWithView();

        Move();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            //pick up object becomes child of ball
            other.transform.SetParent(this.transform);
        }
    }

    private void Move()
    {
        rb.AddForce(moveForceMultiplier * (MoveVector*speed - rb.velocity));

    }
    
    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;

        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        if (dir.magnitude > 1)
            dir.Normalize();
        return dir;

    }

    private Vector3 RotateWithView()
    {
        if (camTransform != null)
        {
            Vector3 dir = camTransform.TransformDirection(MoveVector);
            dir.Set(dir.x, 0, dir.z);
            
            return dir.normalized * MoveVector.magnitude;
        }
        else
        {
            camTransform = Camera.main.transform;
            
            return MoveVector;
        }
    }
}
