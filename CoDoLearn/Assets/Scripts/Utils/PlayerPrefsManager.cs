using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    private const string Token_Key = "Token";
    private const string Email_Key = "Email";
    private const string Name_Key = "Name";
    private const string LastName_Key = "LastName";
    private const string LastLastName_Key = "LastLastName";
    private const string Category_Key = "Category";
    private const string LevelNumber_Key = "LevelNumber";

    public static void SetUserInfo(SessionData session)
    {
        PlayerPrefs.SetString(Token_Key, session.token);
        PlayerPrefs.SetString(Email_Key, session.email);
        PlayerPrefs.SetString(Name_Key, session.name);
        PlayerPrefs.SetString(LastName_Key, session.lastName);
        PlayerPrefs.SetString(LastLastName_Key, session.patronymic);
    }

    public static string GetToken() => PlayerPrefs.GetString(Token_Key);

    public static string GetEmail() => PlayerPrefs.GetString(Email_Key);

    public static string GetFullName()
    {
        return PlayerPrefs.GetString(Name_Key) + " " + PlayerPrefs.GetString(LastName_Key) + " " + PlayerPrefs.GetString(LastLastName_Key);
    }

    public static string GetName() => PlayerPrefs.GetString(Name_Key);

    public static bool HasToken() => PlayerPrefs.HasKey(Token_Key);

    public static void SetCategory(string category) => PlayerPrefs.SetString(Category_Key,category);

    public static string GetCategory() => PlayerPrefs.GetString(Category_Key);

    public static void SetLevelNumber(int value) => PlayerPrefs.SetInt(LevelNumber_Key, value);

    public static int GetLevelNumber() => PlayerPrefs.GetInt(LevelNumber_Key);
}
