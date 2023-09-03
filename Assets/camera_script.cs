using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
        GameObject[] coins = GameObject.FindGameObjectsWithTag("coins");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Game object \"ball\" is at (" + ball.transform.position.x + ", " + ball.transform.position.y + ", " + ball.transform.position.z + ")");
        transform.position = new Vector3(ball.transform.position.x, 
            ball.transform.position.y + 1, 
            ball.transform.position.z - 5);
        //Debug.Log("Game object \"camera\" is at (" 
        //    + transform.position.x + ", " 
        //    + transform.position.y + ", " 
        //    + transform.position.z + ")");
    }
}
