using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System; // for Math.Sqrt and Math.Pow methods

public class ball_script : MonoBehaviour
{
    //double startingPosX, startingPosY, startingPosZ;
    Vector3 startingPos;
    Vector3 startingRot;
    Rigidbody rigidBodyBall;
    // Start is called before the first frame update
    void Start()
    {
        //startingPosX = transform.position.x;
        //startingPosY = transform.position.y;
        //startingPosZ = transform.position.z;
        startingPos = transform.position;
        startingRot = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //double distance = 0;
        //distance = Math.Sqrt(Math.Pow(startingPosX - transform.position.x, 2) + Math.Pow(startingPosY - transform.position.y, 2) + Math.Pow(startingPosZ - transform.position.z, 2));
        //Debug.Log("\nVector length from the starting position is " + distance);
        float dist = Vector3.Distance(startingPos, transform.position);
        //Debug.Log("Distance of this ball from the starting point = " + dist);
        if (dist > 50)
        {
            transform.position = startingPos;
            transform.localEulerAngles = startingRot;
            rigidBodyBall = GetComponent<Rigidbody>();
            //Debug.Log("Velocity of this ball = " + rigidBodyBall.velocity);
            rigidBodyBall.velocity = new Vector3(0, 0, 0);
            rigidBodyBall.angularVelocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space bar is pressed");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 400);
        }
    }

    //void dummyMethod()
    //{
    //    Debug.Log("Test method is dummy.");
    //}
}
