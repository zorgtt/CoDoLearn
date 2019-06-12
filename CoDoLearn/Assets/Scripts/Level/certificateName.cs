using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class certificateName : MonoBehaviour
{
    [SerializeField]
    Text text;

    private void Awake()
    {
        text.text = string.Format("{0} прошел курс по {1}",PlayerPrefsManager.GetFullName(),PlayerPrefsManager.GetCategory());
    }
}
