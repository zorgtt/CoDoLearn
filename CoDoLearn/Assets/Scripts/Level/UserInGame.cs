using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class UserInGame : RequestManager
{
    [SerializeField]
    private string lastactive;

    [SerializeField]
    Text text;

    private void Start()
    {
        LastActiveData lastActiveData = new LastActiveData(PlayerPrefsManager.GetEmail(), DateTime.Now.ToString());
        string model = JsonUtility.ToJson(lastActiveData);
        Debug.Log(model);
        StartCoroutine(PutData(apiUrl + lastactive, new Dictionary<string, string> { { "model", model } }, (req) => CheckForConnection(req)));

    }

    private void CheckForConnection(UnityWebRequest request)
    {
       
    }

}
