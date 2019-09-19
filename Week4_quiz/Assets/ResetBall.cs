using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    public Transform spawnPoint;
    public float threshold;
    public GameObject player;

    void FixedUpdate()
    {
        if (player.transform.position.y < threshold)
            player.transform.position = spawnPoint.position;
        if (player.transform.position.y < threshold)
            player.transform.position = new Vector3(0, 0, 0);
    }
}