using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct RegisterData 
{
    public string email;
    public string name;
    public string lastName;
    public string patronymic;
    public string password;
    public string passwordConfirm;

    public RegisterData(string _email,string _name, string _lastName, string _patronymic,string _password,string _passwordConfirm)
    {
        email = _email;
        name = _name;
        lastName = _lastName;
        patronymic = _patronymic;
        password = _password;
        passwordConfirm = _passwordConfirm;
    }
}
