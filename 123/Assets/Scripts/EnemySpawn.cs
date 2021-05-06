using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    //In this script , we are creating enemy again and again and making them fall from the spawning point.
    //And instantiate it at random positions.

    public GameObject enemy;
    public float PositionLimit;
    public float SpawnRate;
    private void Start()
    {
        //SpawnSpike();
        StartSpawning();
    }
    void SpawnSpike()
    {
        float Randomx= Random.Range(-PositionLimit, PositionLimit);
        //Random.range randomlize the value, so here I have given min value and max value as limit
        //like b/w these to value , object(game spawner) should randomlize.


        Vector2 spawnPosition = new Vector2(Randomx, transform.position.y);
        //we kept the record of randomlize value in variable Randomx.
        //In here, we are changing the position , and arguments are Randomx bcz we want to change the value at x- axis, 
        // but we dont want to change the value at y axis




        Instantiate(enemy, spawnPosition, Quaternion.identity);

        //Instantiate(enemy, transform.position, Quaternion.identity);
        //instantiate -- arguments are as follows--> what we want to instantiate ie 'Enemy', at what position we want to
        //instatntiate like here we want to instantiate where we have spawner, third is if we want to rotate the object
        //Quaternion.identity means we dont want any rotation that is NO ROTATION

    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, SpawnRate);
        //through InvokeRepeating, we can call any function at any number of time within the certain rate.
        //First parameter is --> which function we want to call, second parameter is after how much timw we want
        //to start calling function,, here we have written 1F that is we want to start calling the function
        //after one second . It means after waiting for 1 sec , function will started getting called, third parameter is 
        //we are getting rate through which function is called, suppose we have given 1f that is after every 1 sec , the function
        //will be called
         
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnSpike");
        //It is an inbuilt function in unity.
    }

}
