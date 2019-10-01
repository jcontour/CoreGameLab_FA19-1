using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fish_p;

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
            p = Instantiate(fish_p, new Vector3(9, Random.Range(-4f, 4.5f), 0), Quaternion.identity);
            p.GetComponent<FishMove>().speed = Random.Range(3, 7);
            timer = 0;
        }
    }
}

