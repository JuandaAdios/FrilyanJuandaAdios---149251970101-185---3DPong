using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject spawnLocation;
    public GameObject ball;
    public Vector3 respawnLocation;

    void Start()
    {
        ball = (GameObject)Resources.Load("Ball", typeof(GameObject));
        spawnLocation = GameObject.FindGameObjectWithTag("SpawnPoint");
        respawnLocation = ball.transform.position;

        SpawnCharacter();

    }

    void Update()
    {

    }

    private void SpawnCharacter()
    {
        GameObject.Instantiate(ball, spawnLocation.transform.position, Quaternion.identity);
    }
}
