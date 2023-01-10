using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    [SerializeField]
    GameObject[] ballPrefabs;

    [SerializeField, Header("Range limit X")]
    float spawnLimitXLeft = -22;

    [SerializeField]
    float spawnLimitXRight = 7;

    [SerializeField, Header("Y spawn")]
    float spawnPosY = 30;

    [SerializeField, Header("Random Interval")]
    float minRandomInterval = 0.1f;

    [SerializeField]
    float maxRandomInterval = 3f;




    void Start()
    {
        SpawnRandomBall();
    }


    void SpawnRandomBall()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballIndex = Random.Range(0, ballPrefabs.Length);


        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        Invoke("SpawnRandomBall", Random.Range(minRandomInterval, maxRandomInterval)); //Wazaaaaa !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }

    /*                                  
                   &&&&&&&&&&%&&&%                
                  &&&&&%&&@@@@@@@@&#              
                 &@@@@@@@@@@@@@@@@@&              
              &#&@@@@@@@@@@@@@@@@@@&&.            
         .@@&&&&&@@@@@@@@@@@@@@@@@@@@&@@@@@%      
       &&&&&&&%&@@@@@@@@@@@@@@@@@@&@&&&&&&&&&,    
      &&&&&&&&&&&@&&&&&&@@&&@&&@&@&@@@&@&&&&&/    
     &&&&&&&&&@@@@&&&@&@@@@@@@&@@@@@@@&&&&&&      
      &&&@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@&&&        
        &@@@@@@@@@@@@@@@@@@@@@@@@@&&&&%           
           (&&&@@@@@@@@@@@&&&&&&&# 
     */

















}


