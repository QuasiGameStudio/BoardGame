using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	[SerializeField]
    private GameObject ball;
    // Start is called before the first frame update
    float tempX;
    float tempZ;
    Vector3 movement;

    float speed=100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Accelerometer();
        if (Input.GetKeyDown("w")){
            tempX = ball.transform.position.x;
            tempZ = ball.transform.position.z+speed;
            movement = new Vector3(tempX, 0, tempZ);
            ball.GetComponent<Rigidbody>().AddForce(movement);
        }else if (Input.GetKeyDown("a")){
            tempX = ball.transform.position.x-speed;
            tempZ = ball.transform.position.z;
            movement = new Vector3(tempX, 0, tempZ);
            ball.GetComponent<Rigidbody>().AddForce(movement);
        }else if (Input.GetKeyDown("s")){            
            tempX = ball.transform.position.x;
            tempZ = ball.transform.position.z-speed;
            movement = new Vector3(tempX, 0, tempZ);
            ball.GetComponent<Rigidbody>().AddForce(movement);
        }else if (Input.GetKeyDown("d")){
            tempX = ball.transform.position.x+speed;
            tempZ = ball.transform.position.z;
            movement = new Vector3(tempX, 0, tempZ);
            ball.GetComponent<Rigidbody>().AddForce(movement);
        }
    }

    private void Jump(){

    }
}
