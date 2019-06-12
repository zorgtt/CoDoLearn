using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct LoginData 
{
    public string email;
    public string password;

    public LoginData(string _email,string _password)
    {
        email = _email;
        password = _password;
    }
}
