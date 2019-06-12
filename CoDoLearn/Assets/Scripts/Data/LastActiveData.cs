using System;

public struct LastActiveData
{
    public string emailUser;
    public string lastActive;

    public LastActiveData(string _emailUser, string _lastActive)
    {
        emailUser = _emailUser;
        lastActive = _lastActive;
    }
}
