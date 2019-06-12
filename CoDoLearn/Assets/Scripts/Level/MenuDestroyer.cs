using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDestroyer : MonoBehaviour
{
    [SerializeField]
    Transform destroyChildrenOfGameObj;

    public void DestroyChildren()
    {
        Level[] children = destroyChildrenOfGameObj.GetComponentsInChildren<Level>();
        for (int i = 0; i < children.Length; i++)
        {
            Destroy(destroyChildrenOfGameObj.GetChild(i).gameObject);
        }
    }
}
