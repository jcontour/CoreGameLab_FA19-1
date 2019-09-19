using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour

{
    public GameObject RandomSpawn;
    public float secondsBetweenSpawns = 4;
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
            Instantiate(RandomSpawn, new Vector3(Random.Range(-9, 9), Random.Range(-3, 3), 0), Quaternion.identity);
        }
    }
}
