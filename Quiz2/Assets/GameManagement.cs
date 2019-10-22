using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement Larry;

    private void Awake()
    {
        if (Larry == null)
        {
            Larry = this;
            DontDestroyOnLoad(this);
        }
        else if (Larry != this)
        {
            Destroy(gameObject);
        }
    }

    public int text;

    public void UpdateScore()
    {
        UIManager.Laura.ShowNewSpeed(text);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (text == 0)
        {

            UpdateScore();
            SceneManager.LoadScene(3);
        }
    }
}
//    public void LoseGame()
//    {
//        SceneManager.LoadScene(3);
//        score = 0;
//        UpdateScore();
//    }
//}
