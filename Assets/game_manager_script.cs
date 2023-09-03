using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager_script : MonoBehaviour
{
    int coin_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Restart()
    {
        Application.LoadLevel("ball_sliding");    // obsolete
        //SceneManager.LoadScene("ball_sliding");
    }

    void RedCoinTrigger()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obstacles");
        for (int i = 0; i < obstacles.Length; i++)
            Destroy(obstacles[i]);
    }

    void GetCoin()
    {
        coin_count++;
        Debug.Log("number of coins collected : " + coin_count);
    }
}
