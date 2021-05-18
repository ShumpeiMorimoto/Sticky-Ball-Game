using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitItem : MonoBehaviour
{

    private Rigidbody rb;
    SphereCollider col;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "item")
        {
            Debug.Log("Hit!");
            if (otherObj.rigidbody.mass < col.radius){
                //rb.mass += otherObj.rigidbody.mass;
                Destroy(otherObj.collider);
                Destroy(otherObj.rigidbody);
                otherObj.transform.parent = transform;
                col.radius += otherObj.rigidbody.mass / 15;
                //Vector3 itempos = otherObj.transform.position;
                //Vector3 spherepos = rb.transform.position;
                //float dis = Vector3.Distance(itempos, spherepos);
                //if (dis <= (col.radius + 5) )
                //{
                //    Debug.Log("Hit!");
                //    //rb.mass += otherObj.rigidbody.mass;
                //    Destroy(otherObj.collider);
                //    Destroy(otherObj.rigidbody);
                //    otherObj.transform.parent = transform;
                //    col.radius += otherObj.rigidbody.mass/20;
                //}
            }




        }
    }
}
