using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_script : MonoBehaviour
{
    float delta = 0.05f;
    float rangePosX = 3.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newPosX;
        float curPosX = transform.localPosition.x;
        
        if (curPosX > rangePosX || curPosX < -rangePosX)
            delta = -delta;

        newPosX = curPosX + delta;
        //Debug.Log("delta = " + delta);
        transform.localPosition = new Vector3(newPosX, transform.localPosition.y, transform.localPosition.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        //float elasticity = 100;
        //Vector3 direction = transform.position - collision.gameObject.transform.position;
        //direction = direction.normalized * elasticity;
        //collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);

        Vector3 adder = new Vector3(0.2f, 0.2f, 0.2f);
        collision.gameObject.transform.localScale += adder;
    }
}
