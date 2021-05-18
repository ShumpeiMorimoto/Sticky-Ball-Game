using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    GameObject targetObj;
    Vector3 targetPos;
    float targetsize;
    float targetsize1;
    SphereCollider col;
    bool isOnce = true;
    public float rotateSpeed = 3.0f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
        targetObj = GameObject.Find("Player");
        targetPos = targetObj.transform.position;
        col = targetObj.GetComponent<SphereCollider>();
        targetsize1 = col.radius;
    }

    // Update is called once per frame
    void Update()
    {
        offset = (targetsize1 / (targetsize1 + (targetsize - targetsize1)/2)) * (transform.position - targetPos);
        if (isOnce)
        {
            targetsize = col.radius;
            isOnce = false;
            offset = (transform.position - targetPos);
        }
        targetsize = col.radius;
        targetPos = targetObj.transform.position;
        transform.position = (targetObj.transform.position + ((targetsize1 + (targetsize-targetsize1)/2) / targetsize1) * offset);
        float angelH = Input.GetAxis("Horizontal2");
        transform.RotateAround(targetPos, Vector3.up, angelH * Time.deltaTime * 200f);

       
    }
}
