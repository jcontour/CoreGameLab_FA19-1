using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemies : MonoBehaviour
{
    //public float speed = 3;
    //void Update()
    //{
    //    transform.Translate(Vector3.down * speed * Time.deltaTime);
    //}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("bullet"))
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag.Equals("ground"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
