using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpenerCloser : MonoBehaviour
{
    [SerializeField]
    private GameObject[] panels;

    public void Close()
    {
        foreach(GameObject obj in panels)
        {
            obj.SetActive(false);
        }
    }

    public void Open()
    {
        foreach (GameObject obj in panels)
        {
            obj.SetActive(true);
        }
    }
}
