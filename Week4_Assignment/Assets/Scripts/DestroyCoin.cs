using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // checking if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            //taking the mouse position and converting to vector3
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = worldPoint - transform.position;
            rb.AddForce(new Vector2(direction.x, direction.y), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scored;
        audioSource.Play();

        ScoreScript.scoreValue += 1;
        Destroy(collision.gameObject);

    }
}
