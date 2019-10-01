using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy_p;

    float timer;
    public float interval;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= interval)
        {
            GameObject p;
            p = Instantiate(enemy_p, new Vector3(9, Random.Range(-4f, 4.5f), 0), Quaternion.identity);
            p.GetComponent<HarpoonMove>().speed = Random.Range(5, 10);
            timer = 0;
        }
    }
    //    private void OnCollisionEnter2D(Collision2D collision)
    //    {

    //        ScoreScript.scoreValue = 0;
    //        Destroy(this.gameObject);

    //    }
    //}
}
