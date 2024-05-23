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

    public Slider HeightHair;
    public Slider WidthHair;
    public Slider HeightShirt;
    public Slider WidthShirt;
    public Slider HeightPants;
    public Slider WidthPants;
    public Slider HeightBoards;
    public Slider WidthBoards;

    public GameObject[] hairObjects;
    public GameObject[] shirtObjects;
    public GameObject[] pantsObjects;
    public GameObject[] boardsObjects;

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

    public void ChangeSizeHair()
    {
        float hairSizeH = HeightHair.value;
        float hairSizeW = WidthHair.value;

        foreach (GameObject hair in hairObjects)
        {
            hair.transform.localScale = new Vector3(1.0f * hairSizeH, 1.0f * hairSizeW, 1);
        }
    }

    public void ChangeSizeShirt()
    {
        float shirtSizeH = HeightShirt.value;
        float shirtSizeW = WidthShirt.value;

        foreach (GameObject shirt in shirtObjects)
        {
            shirt.transform.localScale = new Vector3(1.0f * shirtSizeH, 1.0f * shirtSizeW, 1);
        }
    }

    public void ChangeSizePants()
    {
        float pantsSizeH = HeightPants.value;
        float pantsSizeW = WidthPants.value;

        foreach (GameObject pants in pantsObjects)
        {
            pants.transform.localScale = new Vector3(1.0f * pantsSizeH, 1.0f * pantsSizeW, 1);
        }
    }

    public void ChangeSizeBoards()
    {
        float boardSizeH = HeightBoards.value;
        float boardSizeW = WidthBoards.value;

        foreach (GameObject board in boardsObjects)
        {
            board.transform.localScale = new Vector3(1.0f * boardSizeH, 1.0f * boardSizeW, 1);
        }
    }
}
