﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFalling : MonoBehaviour
{
    float speed = 3;


    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
