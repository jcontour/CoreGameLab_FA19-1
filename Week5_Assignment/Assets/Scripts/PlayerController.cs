using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public GameObject GameOverText, RestartButton;
    Rigidbody2D rig;
    public float jumpHeight;
    // Use this for initialization
    void Start()
    {
        GameOverText.SetActive(false);
        RestartButton.SetActive(false);

        rig = GetComponent<Rigidbody2D>();
    }

    public void jump()
    {

        rig.velocity = new Vector2(0, jumpHeight);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("enemy"))
        {
            GameOverText.SetActive(true);
            RestartButton.SetActive(true);
            Destroy(this.gameObject);
        }
    }



}