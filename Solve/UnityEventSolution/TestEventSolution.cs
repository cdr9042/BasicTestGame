using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class StringEvent : UnityEvent<string>
{
}

public class TestEventSolution : MonoBehaviour
{
    [SerializeField] UnityEvent onClick;
    [SerializeField] StringEvent onClickText;
    [SerializeField] InputField inputField;

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
    public void LogBtnClick()
    {
        Debug.Log("Clicked");
    }

    public void LogInputField(string str)
    {
        Debug.Log(str);
    }
}