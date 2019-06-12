using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Category : RequestManager
{
    [SerializeField]
    LevelCreator levelCreator;

    [SerializeField]
    private string category;

    [SerializeField]
    private string levels;

    [SerializeField]
    private GameObject close;

    [SerializeField]
    private GameObject open;

    [SerializeField]
    private GameObject[] info;

    public void StartCreating()
    {
        SendRequest();
    }

    private void SendRequest()
    {
        //PlayerPrefsManager.SetCategory(category);
        StartCoroutine(GetData(apiUrl +"/api/Language/" +category+ levels,(req) => CheckForConnection(req)));
    }

    private void CheckForConnection(UnityWebRequest request)
    {

        if (request.responseCode == 0)
        {
           // responseText.text = "Проверте интернет подключение";
        }
        else
            ResponseHandler(request.downloadHandler.text);
    }

    private void ResponseHandler(string response)
    {
        if (response.Contains("level_finished"))
        {
            FinishedLevels finishedLevels = JsonUtility.FromJson<FinishedLevels>(response);

            if (category == "Cp")
                PlayerPrefsManager.SetCategory("C#");
            else
                PlayerPrefsManager.SetCategory(category);

            levelCreator.CreateLevels(finishedLevels.level_finished);
            close.SetActive(false);
            open.SetActive(true);
            foreach(GameObject obj in info)
            {
                obj.SetActive(false);
            }
        }
        
    }
}

