using System;

public struct AnswerData 
{

    public string emailUser;
    public string nameLanguage;
    public int levelID;
    public DateTime time;
    public bool isCorrect;

    public AnswerData(string _emailUser, string _nameLanguage, int _levelID, DateTime _time, bool _isCorrect)
    {
        emailUser = _emailUser;
        nameLanguage = _nameLanguage;
        levelID = _levelID;
        time = _time;
        isCorrect = _isCorrect;
    }
}
