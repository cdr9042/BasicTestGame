using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TestEvent : MonoBehaviour
{
    [SerializeField] UnityEvent onClick;
    [SerializeField] UnityEvent<string> onClickText;
    [SerializeField] InputField inputField;

    //for buttons
    public void OnBtnClick()
    {
    }

    public void OnBtnClickLogText()
    {
    }

    //for event
    public void LogBtnClick()
    {
        Debug.Log("Clicked");
    }

    public void LogInputField(string str)
    {
        Debug.Log(str);
    }
}