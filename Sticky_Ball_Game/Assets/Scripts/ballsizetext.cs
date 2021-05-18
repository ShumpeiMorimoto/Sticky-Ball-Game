using UnityEngine;
using System.Collections;
using UnityEngine.UI;  ////ここを追加////
using System;

public class ballsizetext : MonoBehaviour
{

    GameObject targetObj;
    SphereCollider col;

    // Use this for initialization
    void Start()
    {
        targetObj = GameObject.Find("Player");
        col = targetObj.GetComponent<SphereCollider>();
        this.GetComponent<Text>().text = "ballsize";
    }

    // Update is called once per frame
    private void Update()
    {
        this.GetComponent<Text>().text = Mathf.Round(col.radius*1000f)/1000f + "m";

    }
}