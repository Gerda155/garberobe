using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image : MonoBehaviour
{
    public GameObject skirt1;
    public GameObject skirt2;
    public GameObject skirt3;
    public GameObject skirt4;

    public GameObject shirt1;
    public GameObject shirt2;
    public GameObject shirt3;
    public GameObject shirt4;

    public GameObject hair1;
    public GameObject hair2;
    public GameObject hair3;

    public GameObject shoes1;
    public GameObject shoes2;
    public GameObject shoes3;

    public void showSkirt1(bool value)
    {
        skirt1.SetActive(value);
    }
    public void showSkirt2(bool value)
    {
        skirt2.SetActive(value);
    }
    public void showSkirt3(bool value)
    {
        skirt3.SetActive(value);
    }
    public void showSkirt4(bool value)
    {
        skirt4.SetActive(value);
    }

    public void showShirt1(bool value)
    {
        shirt1.SetActive(value);
    }
    public void showShirt2(bool value)
    {
        shirt2.SetActive(value);
    }
    public void showShirt3(bool value)
    {
        shirt3.SetActive(value);
    }
    public void showShirt4(bool value)
    {
        shirt4.SetActive(value);
    }

    public void showHair1(bool value)
    {
        hair1.SetActive(value);
    }
    public void showHair2(bool value)
    {
        hair2.SetActive(value);
    }
    public void showHair3(bool value)
    {
        hair3.SetActive(value);
    }

    public void showShoes1(bool value)
    {
        shoes1.SetActive(value);
    }
    public void showShoes2(bool value)
    {
        shoes2.SetActive(value);
    }
    public void showShoes3(bool value)
    {
        shoes3.SetActive(value);
    }
}

