﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_coin_script : MonoBehaviour
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
            GameObject.Find("GameManager").SendMessage("RedCoinTrigger");
            Destroy(gameObject);
        }
    }
}
