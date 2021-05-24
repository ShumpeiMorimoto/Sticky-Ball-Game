using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    Button start;

    // Start is called before the first frame update
    void Start()
    {
        start = GameObject.Find("/Canvas/StartButton").GetComponent<Button>();

        start.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
