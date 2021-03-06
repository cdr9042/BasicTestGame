using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TestEvent : MonoBehaviour
{
    [SerializeField] UnityEvent onClick;
    [SerializeField] UnityEvent<string> onClickText;
    InputField inputField;

    //for buttons
    public void OnBtnClick()
    {
        onClick.Invoke();
    }

    public void OnBtnClickLogText()
    {
        onClickText.Invoke(inputField.text);
    }

    //for event
    public void LogSomething()
    {
        Debug.Log("Clicked");
    }

    public void LogInputField(string str)
    {
        Debug.Log(str);
    }
}