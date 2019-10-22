using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareMove : MonoBehaviour
{
    public Slider speedslider;

    public int moveSpeed = 1;
    private Vector3 mousePosition;

    void Update()
    {

        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, (moveSpeed * speedslider.value) * Time.deltaTime);


    }
}