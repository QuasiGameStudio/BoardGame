using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceWallUp : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pushDown;
    void Start()
    {
        pushDown = new Vector3(0f,0f,-5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(pushDown * 200);
    }
}
