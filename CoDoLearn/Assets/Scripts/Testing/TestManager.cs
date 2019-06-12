using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class TestManager : MonoBehaviour
{
    [SerializeField]
    private AnswerSender answerSender;

    [SerializeField]
    private Toggle[] toggles;

    [SerializeField]
    private Text question;

    [SerializeField]
    private Text checkAnswer;

    [SerializeField]
    private GameObject start;

    [SerializeField]
    private GameObject Buttons;

    [SerializeField]
    private GameObject certificate;

    private string category;

    private string[] questions;

    private string[][] answers;

    private string[] rightAnswers;

    public int index;

    private bool flag;

    private bool startFlag;

    private void Awake()
    {
        category = PlayerPrefsManager.GetCategory();
        Debug.Log(category);
        index = PlayerPrefsManager.GetLevelNumber();
        questions = Data.GetQuestion(category);
        answers = Data.GetAnswers(category);
        rightAnswers = Data.GetRightAnswer(category);
        flag = true;
    }


    private void Start()
    {
        Debug.Log(index);
        if (index == 1)
        {
            Debug.Log(index);
            start.SetActive(true);
            flag = true;
        }
        else if(index == 16)
        {
            Instantiate(certificate);
        }
        else
            SetUp();
    }

    public void CheckAnswer()
    {
        for(int i = 0;i < toggles.Length; i++)
        {
            if (toggles[i].isOn)
            {
                if (toggles[i].GetComponentInChildren<Text>().text == rightAnswers[index])
                {
                    Debug.Log(true);
                    checkAnswer.color = Color.green;
                    checkAnswer.text = "Верно";
                    flag = true;
                }
                else
                {
                    Debug.Log(false);
                    flag = false;
                    checkAnswer.color = Color.red;
                    checkAnswer.text = "Вы не правы";
                }
            }
        }
    }

    public void SetLevel()
    {
        offToggles();
        if (index == 15 && flag)
        {
            answerSender.SendAnswer(index);
            Instantiate(certificate);
        }

        else if(flag)
        {
            Buttons.SetActive(true);
            start.SetActive(false);
            answerSender.SendAnswer(index);
            index++;
            for (int i = 0; i < toggles.Length; i++)
            {
                toggles[i].GetComponentInChildren<Text>().text = answers[index][i];
            }
            question.text = questions[index];
            Debug.Log("Index " + index.ToString());
            checkAnswer.text = string.Empty;
            flag = false;
        }
    }

    private void SetUp()
    {
        Buttons.SetActive(true);
        start.SetActive(false);
        for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].GetComponentInChildren<Text>().text = answers[index][i];
        }
        question.text = questions[index];
        Debug.Log("Index " + index.ToString());
        checkAnswer.text = string.Empty;
    }

    private void offToggles()
    {
        foreach(var tog in toggles)
        {
            tog.isOn = false;
        }
    }
    

}

