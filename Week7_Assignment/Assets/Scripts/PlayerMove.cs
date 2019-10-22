using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    public float forceAmount;

    private Rigidbody2D rb;

    public bool grounded;
    public LayerMask groundsource;

    private Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    rb.velocity = transform.right * speed;
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    rb.velocity = transform.right * -speed;
        //}
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * 0.25f;

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);


        grounded = Physics2D.IsTouchingLayers(col, groundsource);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, forceAmount);
            }

        }
    }
    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.tag.Equals("enemy"))
    //    {
    //        SceneManager.LoadScene("GameOver");
    //    }

    //}
}
