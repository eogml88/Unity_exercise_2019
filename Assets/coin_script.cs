using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "ball")
        {
            GameObject.Find("GameManager").SendMessage("GetCoin");
            
            Vector3 adder = new Vector3(0.2f, 0.2f, 0.2f);
            collider.gameObject.transform.localScale -= adder;

            Destroy(gameObject);
        }
    }
}
