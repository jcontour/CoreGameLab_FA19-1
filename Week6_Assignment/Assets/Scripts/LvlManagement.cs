using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManagement : MonoBehaviour
{
    public GameObject platform_p;
    public float speed = 10.0f;
    public float interval;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            GameObject p;
            p = Instantiate(platform_p, new Vector3(9, -2.5f, 0), Quaternion.identity);
            //p.GetComponent<LvlManagement>().speed = 13;
            Vector3 randomSize = new Vector3(Random.Range(4, 11), 0.7f, 1);
            p.transform.localScale = randomSize;
            p.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.3f, 1f);

            timer = 0;
        }
    }

}
