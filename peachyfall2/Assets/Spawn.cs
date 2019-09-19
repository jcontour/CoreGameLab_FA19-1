using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject fallingPeachyPrefab;
    public float secondsBetweenSpawns = 1;
    float nextSpawnTime;
    Vector2 screen;
   
    void Start()
    {
        screen = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawns;
            Vector2 spawnPosition = new Vector2 (Random.Range(-screen.x, screen.x), screen.y);
            Instantiate(fallingPeachyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
