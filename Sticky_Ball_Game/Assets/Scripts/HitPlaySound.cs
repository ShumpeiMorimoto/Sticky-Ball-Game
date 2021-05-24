using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour
{
    public AudioClip sound;
    Rigidbody rb;
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
            if (otherObj.rigidbody.mass < col.radius)
            {
                AudioSource.PlayClipAtPoint(sound, transform.position);
                Debug.Log("Sound!!");
            }
                
        }
        
    }
}
