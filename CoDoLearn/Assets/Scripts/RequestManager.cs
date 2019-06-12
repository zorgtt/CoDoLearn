using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.Networking;

public delegate void ResponseHandler(UnityWebRequest response);

public class RequestManager : MonoBehaviour
{
    protected const string apiUrl = "https://language-testing-app.herokuapp.com";
    protected int timeout = 15; 


    protected IEnumerator PostData(string url, Dictionary<string,string> keyValues, ResponseHandler responseHandler)
    {
        string requestText = string.Empty;
        foreach (var keyValuePair in keyValues)
            requestText += keyValuePair.Value + "&";

        requestText = requestText.TrimEnd('&');


        Debug.Log("POST data: " + requestText);

        using (UnityWebRequest request = UnityWebRequest.Put(url, Encoding.UTF8.GetBytes(requestText.ToCharArray())))
        {
            request.timeout = timeout;
            request.method = UnityWebRequest.kHttpVerbPOST;
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log("Code: " + request.responseCode);
                Debug.Log("Output: " + request.downloadHandler.text);
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log("Request successful. Output: " + request.downloadHandler.text);
            }

            //CheckInternet.CheckForInternetConnection(request.responseCode);

            if (request != null && Application.internetReachability != NetworkReachability.NotReachable)
                responseHandler(request);

            else Debug.Log("Response is empty");
        }
    }

    protected IEnumerator GetData(string url,ResponseHandler responseHandler)
    {
        Debug.Log(url);
        using(UnityWebRequest request = UnityWebRequest.Get(url))
        {
            request.timeout = timeout;
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Authorization", "Bearer " + PlayerPrefsManager.GetToken());

            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log("Code: " + request.responseCode);
                Debug.Log("Output: " + request.downloadHandler.text);
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log("Request successful. Output: " + request.downloadHandler.text);
            }


            if (request != null && Application.internetReachability != NetworkReachability.NotReachable)
                responseHandler(request);

            else Debug.Log("Response is empty");
        }
    }

    protected IEnumerator PutData(string url, Dictionary<string, string> keyValues, ResponseHandler responseHandler)
    {
        string requestText = string.Empty;
        foreach (var keyValuePair in keyValues)
            requestText += keyValuePair.Value + "&";

        requestText = requestText.TrimEnd('&');



        Debug.Log("POST data: " + requestText);

        using (UnityWebRequest request = UnityWebRequest.Put(url, Encoding.UTF8.GetBytes(requestText.ToCharArray())))
        {
            request.timeout = timeout;
            request.method = UnityWebRequest.kHttpVerbPUT;
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Authorization", "Bearer " + PlayerPrefsManager.GetToken());

            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log("Code: " + request.responseCode);
                Debug.Log("Output: " + request.downloadHandler.text);
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log("Request successful. Output: " + request.downloadHandler.text);
            }

            //CheckInternet.CheckForInternetConnection(request.responseCode);

            if (request != null && Application.internetReachability != NetworkReachability.NotReachable)
                responseHandler(request);

            else Debug.Log("Response is empty");
        }
    }

}
