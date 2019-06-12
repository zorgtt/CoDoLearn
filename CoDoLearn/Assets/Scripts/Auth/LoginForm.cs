using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginForm : MonoBehaviour
{
    [SerializeField]
    private AuthManager auth;

    [SerializeField]
    private InputField email;

    [SerializeField]
    private InputField password;

    [SerializeField]
    private Button loginButton;

    [SerializeField]
    private Text responseText;

    private void Awake()
    {
        loginButton.interactable = false;
        loginButton.image.color = new Color(255, 255, 255, 140);
        loginButton.onClick.AddListener(Login);
        email.onValueChanged.AddListener(str => CheckFields(str));
        password.onValueChanged.AddListener(str => CheckFields(str));
    }

    public void CheckFields(string text)
    {
        bool isFormCorrect = email.text.CheckEmail()
            && password.text.CheckPassword();
        ActivateButton(isFormCorrect);
    }

    private void ActivateButton(bool flag)
    {
        if (flag)
            responseText.text = string.Empty;

        loginButton.interactable = flag;
        loginButton.image.color = new Color(255, 255, 255, 255);

    }

    public void Login()
    {
        LoginData loginData = new LoginData(email.text, password.text);
        auth.LoginUser(loginData, (req) => CheckForConnection(req));
    }

    private void CheckForConnection(UnityWebRequest request)
    {

        if (request.responseCode == 0)
        {
            responseText.text = "Проверте интернет подключение";
        }
        else
            ResponseHandler(request.downloadHandler.text);
    }

    private void ResponseHandler(string response)
    {
        if (response.Contains("token"))
        {
            SessionData session = JsonUtility.FromJson<SessionData>(response);

            PlayerPrefsManager.SetUserInfo(session);

            SceneManager.LoadScene(1);

        }
        else
        {
            responseText.text = "Неверный логин или пароль";
        }
    }

    void OnDisable()
    {
        responseText.text = string.Empty;
        password.text = string.Empty;
        email.text = string.Empty;
    }
}
