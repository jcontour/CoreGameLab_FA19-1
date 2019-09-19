using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnCollision : MonoBehaviour
{
    public float threshold;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreScript.scoreValue += 1;



    }
    private void Update()
    {
        if (transform.position.y < threshold)
            ScoreScript.scoreValue = 0;
    }
}

