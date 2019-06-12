using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    [SerializeField]
    Text text;

    private void Awake()
    {
        text.text = PlayerPrefsManager.GetName();
    }
}