using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_pos_book : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(67, 85);
        y = Random.Range(1, 6);
        z = Random.Range(65, 90);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

}