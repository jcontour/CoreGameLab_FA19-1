using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatforms : MonoBehaviour
{
    public GameObject platform_p;
    public GameObject platform_p1;
    public GameObject platform_p2;
    public GameObject platform_p3;
    public GameObject platform_p4;
    public GameObject platform_p5;
    public GameObject platform_p6;
    public GameObject platform_p7;
    public GameObject platform_p8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
