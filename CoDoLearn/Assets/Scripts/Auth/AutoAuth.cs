using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AutoAuth : MonoBehaviour
{
    private void Awake()
    {
        if (!PlayerPrefsManager.HasToken())
        {
            gameObject.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}
