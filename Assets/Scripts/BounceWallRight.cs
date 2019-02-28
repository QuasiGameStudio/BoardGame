using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceWallRight : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pushLeft;
    void Start()
    {
        pushLeft = new Vector3(-5f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(pushLeft * 200);
    }
}
