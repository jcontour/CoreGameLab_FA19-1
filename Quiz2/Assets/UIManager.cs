using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Laura;

    public Slider slider;
    public Text speedText;

    private void Awake()
    {
        if (Laura == null)
        {
            Laura = this;
            DontDestroyOnLoad(this);
        }
        else if (Laura != this)
        {
            Destroy(gameObject);
        }
    }

    public void ShowNewSpeed(int text)
    {
        speedText.text = slider.value.ToString();
    }

}