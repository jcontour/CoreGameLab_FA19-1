using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public GameObject crosshairs;
    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject firePoint;

    public int rotationOffset = 180;

    public float bulletSpeed = 60.0f;

    private Vector3 target;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ + rotationOffset);

        if (Input.GetMouseButtonDown(0))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
        }
    }
    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = firePoint.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
//// Start is called before the first frame update
//void Start()
//{

//}

//// Update is called once per frame
//void Update()
//{
//    Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
//    difference.Normalize();

//    float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
//    transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rotationOffset);
//}