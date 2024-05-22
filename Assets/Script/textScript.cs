using System;
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
    public GameObject heroHolder;
    public GameObject scroll;
    public Sprite[] spriteArray;


    public void getText()
    {
        year = int.Parse(inputFieldAge.GetComponent<Text>().text);
        int age = 2024 - year;
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = "Sveiki, "+text+"! Tev ir "+age+" gadi";
    }

    public void changeHero(int index)
    {
        heroHolder.GetComponent<Image>().sprite = spriteArray[index];
        if(index == 0)
            scroll.GetComponent<Text>().text = "text pro Gerda";
        else if(index == 1)
            scroll.GetComponent<Text>().text = "text pro Polina";

    }
}
