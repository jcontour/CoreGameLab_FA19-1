using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoingOnCollision : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
        }
    }
}