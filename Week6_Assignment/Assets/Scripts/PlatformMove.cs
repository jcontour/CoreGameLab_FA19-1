using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed;

    GameObject platform_p;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= -15f)
        {
            Destroy(this.gameObject);
        }
    }
}

