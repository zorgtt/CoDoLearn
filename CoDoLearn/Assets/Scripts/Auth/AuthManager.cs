using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthManager : RequestManager
{
    [SerializeField]
    private string logIn;

    [SerializeField]
    private string registr;


    public void LoginUser(LoginData loginData, ResponseHandler responseHandler)
    {
        string data = JsonUtility.ToJson(loginData);
        StartCoroutine(PostData(apiUrl+logIn,new Dictionary<string, string> { { "data" , data} },responseHandler));
    }

    public void RegistUser(RegisterData registerData, ResponseHandler responseHandler)
    {
        string data = JsonUtility.ToJson(registerData);
        StartCoroutine(PostData(apiUrl + registr,new Dictionary<string, string>{ {"data", data} }, responseHandler));
    }
}
