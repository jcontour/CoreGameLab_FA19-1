using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject pearwinnertext;
    public float resetDelay;

    void Awake()

    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);


    }

    public void Win()
    {
        pearwinnertext.SetActive (true);
        Time.timeScale = .5f;
        Invoke("Reset", resetDelay);
    }

    [System.Obsolete]
    private void Reset()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel (Application.loadedLevel);
    }
}
        //display a Win Message
        //slow down time for dramatic effect
        //reset game