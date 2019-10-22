using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {


    }

    public void NextScene()
    {
        SceneManager.LoadScene("Scene02");
    }
}
