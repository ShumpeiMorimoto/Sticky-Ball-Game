using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    GameObject targetObj;
    Vector3 targetPos;

    public float rotateSpeed = 3.0f;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        targetObj = GameObject.Find("Player");
        targetPos = targetObj.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

        float angelH = Input.GetAxis("Horizontal2");

        transform.RotateAround(targetPos, Vector3.up, angelH * Time.deltaTime * 200f);

       
    }
}
