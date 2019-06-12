using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

public class AnswerSender : RequestManager
{
    [SerializeField]
    private string answer;

    [SerializeField]
    Text text;

    public void SendAnswer(int index)
    {
        AnswerData answerData = new AnswerData(PlayerPrefsManager.GetEmail(), PlayerPrefsManager.GetCategory(), index, DateTime.Now, true);
        string data = JsonUtility.ToJson(answerData);
        StartCoroutine(PutData(apiUrl + answer, new Dictionary<string, string> { { "data", data } }, (req) => CheckForConnection(req)));
    }

    private void CheckForConnection(UnityWebRequest request)
    {
    }



}
