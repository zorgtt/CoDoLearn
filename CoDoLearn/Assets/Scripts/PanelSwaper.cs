using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwaper : MonoBehaviour
{
    [SerializeField]
    private GameObject panelToClose;

    [SerializeField]
    private GameObject panelToOpen;

    public void Swap()
    {
        panelToClose.SetActive(false);
        panelToOpen.SetActive(true);
    }
}
