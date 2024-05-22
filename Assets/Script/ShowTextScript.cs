using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    string playerName;
    int age;
    public GameObject inputNameField;
    public GameObject inputAgeField;
    public GameObject DisplayField;

    public void getText()
    {
        playerName = inputNameField.GetComponent<InputField>().text;
        age = int.Parse(inputAgeField.GetComponent<InputField>().text);
        int currentYear = System.DateTime.Now.Year;
        DisplayField.GetComponent<Text>().text = playerName.ToLower() + " you're " + (currentYear - age)+ " years old!";
    }
}
