using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_pos : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(15, 60);
        y = 10;
        z = Random.Range(60, 210);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

}
