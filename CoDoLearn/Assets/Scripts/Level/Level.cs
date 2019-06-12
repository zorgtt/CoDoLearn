using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class Level : MonoBehaviour
{
    [SerializeField]
    Text text;

    [SerializeField]
    Image background;

    private int numerInt;

    private bool closed;

    public void Init(string _number,int number, bool _closed,Color color)
    {
        text.text = _number;
        numerInt = number;
        closed = _closed;
        background.color = color;
        
        
    }

    public void LoadLevel()
    {
        if (closed || numerInt == 15 && closed)
        {
            PlayerPrefsManager.SetLevelNumber(numerInt);
            SceneManager.LoadScene(2);
        }
    }
}
