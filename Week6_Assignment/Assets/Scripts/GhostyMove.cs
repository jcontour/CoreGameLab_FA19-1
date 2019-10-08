using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostyMove : MonoBehaviour
{

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
        grounded = Physics2D.IsTouchingLayers(col, groundsource);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, forceAmount);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManagement.Larry.score++;
        GameManagement.Larry.UpdateScore();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("endzone"))
        {
            GameManagement.Larry.LoseGame();
        }

    }


}