using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rangeRotZ = 45f; // 0 <= rangeRotZ <= 90
        float rotZ = transform.localEulerAngles.z;
        Debug.Log("rotation z of slide = " + rotZ);
        Debug.Log("horizontal direction input = " + Input.GetAxis("Horizontal"));
        if (Input.GetAxis("Horizontal") <= 0) // when left direction key is pressed
        {
            if (rotZ > rangeRotZ && rotZ < 90)
            { 
                transform.localEulerAngles = new Vector3(10, 0, rangeRotZ);
            }
            else
            {
                rotZ -= Input.GetAxis("Horizontal");
                transform.localEulerAngles = new Vector3(10, 0, rotZ);
            }
        }
        else if(Input.GetAxis("Horizontal") > 0) // when right direction key is pressed
        {
            if (rotZ < 360 - rangeRotZ && rotZ > 270)
            {
                transform.localEulerAngles = new Vector3(10, 0, 360 - rangeRotZ);
            }
            else
            {
                rotZ -= Input.GetAxis("Horizontal");
                transform.localEulerAngles = new Vector3(10, 0, rotZ);
            }
        }

        if(Input.touchCount > 0 || Input.GetMouseButton(0)) // left button of mouse is pressed
        {
            Debug.Log("mouse position = " + Input.mousePosition);
            if (Input.mousePosition.x < Screen.width / 2) // the pressed point is on the left half of the screen
            {
                if (rotZ > rangeRotZ && rotZ < 90)
                {
                    transform.localEulerAngles = new Vector3(10, 0, rangeRotZ);
                }
                else
                {
                    transform.localEulerAngles = new Vector3(10, 0, rotZ + 1f);
                }
            }
            else if (Input.mousePosition.x > Screen.width / 2) // the pressed point is on the right half of the screen
            {
                if (rotZ < 360 - rangeRotZ && rotZ > 270)
                {
                    transform.localEulerAngles = new Vector3(10, 0, 360 - rangeRotZ);
                }
                else
                {
                    transform.localEulerAngles = new Vector3(10, 0, rotZ - 1f);
                }
            }
        }
    }
}
