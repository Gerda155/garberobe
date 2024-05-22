using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    string text;
    int year;
    public GameObject inputField;
    public GameObject inputFieldAge;
    public GameObject displayField;

    public void getText()
    {
        year = int.Parse(inputFieldAge.GetComponent<Text>().text);
        int age = 2024 - year;
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = "Sveiki, "+text.ToLower()+"! Tev ir "+age+" gadi";
    }
}
