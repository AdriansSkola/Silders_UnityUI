using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject hair1;
    public GameObject hair2;
    public GameObject hair3;
    public GameObject hair4;

    public GameObject shirt1;
    public GameObject shirt2;
    public GameObject shirt3;
    public GameObject shirt4;

    public GameObject pant1;
    public GameObject pant2;
    public GameObject pant3;
    public GameObject pant4;

    public GameObject shoe1;
    public GameObject shoe2;
    public GameObject shoe3;

    public GameObject CharHolder;
    public Sprite[] SpriteArray;

    public void showHair(bool value)
    {
        hair1.SetActive(value);
        hair2.SetActive(value);
        hair3.SetActive(value);
        hair4.SetActive(value);
    }

    public void showShirt(bool value)
    {
        shirt1.SetActive(value);
        shirt2.SetActive(value);
        shirt3.SetActive(value);
        shirt4.SetActive(value);
    }

    public void showPant(bool value)
    {
        pant1.SetActive(value);
        pant2.SetActive(value);
        pant3.SetActive(value);
        pant4.SetActive(value);
    }

    public void showShoe(bool value)
    {
        shoe1.SetActive(value);
        shoe2.SetActive(value);
        shoe3.SetActive(value);
    }

    public void changeImage(int index)
    {
        CharHolder.GetComponent<Image>().sprite = SpriteArray[index];
    }
}
