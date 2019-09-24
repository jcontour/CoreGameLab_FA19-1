using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreScript.scoreValue = 0;
        Destroy(collision.gameObject);

    }
}
