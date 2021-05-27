using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_pos_animal : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-92, 92);
        y = 5;
        z = Random.Range(-40, -143);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

}
