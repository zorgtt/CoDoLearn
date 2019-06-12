using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class RegisterForm : MonoBehaviour
{
    [SerializeField]
    private AuthManager auth;

    [SerializeField]
    private InputField email;

    [SerializeField]
    private InputField userName;

    [SerializeField]
    private InputField userLastName;

    [SerializeField]
    private InputField userLastLastName;

    [SerializeField]
    private InputField password;

    [SerializeField]
    private InputField confirmPassword;

    [SerializeField]
    private Button registerButton;

    [SerializeField]
    private Text responseText;

    private void Awake()
    {
        email.onValueChanged.AddListener(str => CheckFields(str));
        password.onValueChanged.AddListener(str => CheckFields(str));
        userName.onValueChanged.AddListener(str => CheckFields(str));
        userLastName.onValueChanged.AddListener(str => CheckFields(str));
        userLastLastName.onValueChanged.AddListener(str => CheckFields(str));
        registerButton.interactable = false;
        registerButton.image.color = new Color(255, 255, 255, 140);
        registerButton.onClick.AddListener(Register);
    }

    public void CheckFields(string text)
    {
        if (email.text.CheckEmail())
        {
            responseText.text = "Не верно указан логин";
        }
        else if (password.text != confirmPassword.text)
        {
            responseText.text = "Пароли не совпадают";
        }
        else if (password.text.Length < 5)
        {
            responseText.text = "Пароль должен состоять минимум из 6 символов";
        }
        bool isFormCorrect = email.text.CheckEmail()
            && password.text.CheckPassword()  && password.text == confirmPassword.text;
        ActivateButton(isFormCorrect);
    }

    private void ActivateButton(bool flag)
    {
        if(flag)
        responseText.text = string.Empty;

        registerButton.interactable = flag;
        registerButton.image.color = new Color(255, 255, 255, 255);

    }

    public void Register()
    {
        RegisterData registerData = new RegisterData(email.text, userName.text, userLastName.text,userLastLastName.text,password.text,confirmPassword.text);
        auth.RegistUser(registerData, (req) => CheckForConnection(req));
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
            ErrorData errorData = JsonUtility.FromJson<ErrorData>(response);
            responseText.text = errorData.description;
        }
    }

    void OnDisable()
    {
        responseText.text = string.Empty;
        password.text = string.Empty;
        email.text = string.Empty;
    }
}
