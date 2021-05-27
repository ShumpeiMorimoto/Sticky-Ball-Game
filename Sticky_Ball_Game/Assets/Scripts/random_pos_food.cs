using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_pos_food : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-78, -15);
        y = 5;
        z = Random.Range(60, 215);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

}
