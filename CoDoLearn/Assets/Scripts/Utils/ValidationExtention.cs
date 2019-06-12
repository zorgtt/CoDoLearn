using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public static class ValidationExtention
{
    public static bool CheckEmail(this string str)
    {
        string pattern = @"^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@([a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$";
        Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
        return (reg.IsMatch(str));
    }

    public static bool CheckPassword(this string str)
    {
        return !string.IsNullOrEmpty(str) && !str.Contains(" ");
    }

    public static bool CheckField(this string str)
    {
        
        return !string.IsNullOrEmpty(str);
    }
}
