using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    //public GameObject[] spawnLocation ;
    public GameObject ball;

    private Vector3 respawnLocation;

    void Awake()
    {
        spawnLocation = GameObject.FindGameObjectWithTag("SpawnPoint");
    }
    
    
    void Start()
    {
      ball = (GameObject)Resources.Load("Ball", typeof(GameObject));

      respawnLocation = ball.transform.position;

      SpawnBall();   
    }

    void Update()
    {
        
    }

    private void SpawnBall()
    {
        int spawn = Random.Range(0, spawnLocation.Length);
        GameObject.Instantiate(ball, spawnLocation[spawn].transform.position, Quaternion.identity);
    }
}
